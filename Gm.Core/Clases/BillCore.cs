using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    
    public class BillCore
    {
        #region Variables
        public long? IDFactura
        {
            get;
            private set;
        }
        public long IdProducto
        {
            get;
            set;
        }
        public string CodBarras
        {
            get;
            set;
        }
        public string Detalle
        {
            get;
            set;
        }
        public float? Precio
        {
            get;
            set;
        }
        public int? Unidades
        {
            get;
            set;
        }
        public float? Iva
        {
            get;
            private set;
        }
        public bool? IvaAplica
        {
            get;
            set;
        }
        public float? SubTotal
        {
            get;
            private set;
        }
      
        public float? Total {
            get
            {
                float? resul = Precio * Unidades;
                if (IvaAplica == true)
                {
                    //var resp = new Repository<Parametros>().GetAll();
                    var myIva = General.Iva/100;
                    
                    Iva = Precio * myIva*Unidades;

                    SubTotal = resul - Iva;

                }
                else
                {
                    Iva = null;
                    SubTotal = null;
                }
            
                return resul;
            }
            
        }
        public MedidaMetrica Medida
        {
            get;
            set;
        }

    public Marca Marca_
        { get; set; }

        
        public string Error { get; set; }
        
        #endregion

        //private char Venta;
        private char Compra;
        private readonly List<FacturaDetalle> facturaDetalles = new List<FacturaDetalle>();

        
        List<Kardex> kardices = new List<Kardex>();
        
        Ajustes ajustes = new Ajustes();
        
        ArrayList misSinks = new ArrayList();
        public BillCore()
        {
            Marca_ = new Marca();
            this.Medida = new MedidaMetrica();
            Compra = 'C';
        }
        /// <summary>
        /// Graba factura ventas
        /// </summary>
        /// <param name="cliente">Cliente</param>
        /// <param name="detalle">List<BillCore></param>
        /// <param name="numFactura">int</param>
        /// <returns>bool</returns>
        public bool Save(Cliente cliente, List<BillCore> detalle, int numFactura, out long? IdFactura, string miObservacion)
        {
            bool Result = true;
            Cliente cli = cliente;
            Factura fac = null;
            IdFactura = null;

            var repositoryFactura = new Repository<Factura>();
            var repositoryDetalle = new Repository<FacturaDetalle>();
            var repositoryKardex = new Repository<Kardex>();
            var repositoryProducto = new Repository<Producto>();
            //List<Kardex> detalle_ = new List<Kardex>();

            try
            {
                //grabamos la cabecera factura
                int rowFactura = repositoryFactura.Count() + 1;

                fac = repositoryFactura.Create(new Factura
                {
                    IDFactura = rowFactura,
                    IDCliente = cli.IDCliente,
                    Numero = String.Format("{0:00000}", numFactura),
                    Estado = "A",
                    Fecha = DateTime.Now,
                    FechaSistema = DateTime.Now,
                    IDTerminal = Convert.ToInt16(General.Terminal),
                    Observacion=miObservacion,
                    Tipo="V"
                });
                IDFactura = fac.IDFactura;
                IdFactura = IDFactura;
                if (fac == null)
                    throw new Exception(repositoryFactura.Error);

                //grabamos el detalle
                int rowDetalle = repositoryDetalle.Count() + 1;
                int rowKardex = repositoryKardex.Count() + 1;

                foreach (BillCore de in detalle)
                {
                    //Control si en la siguiente linea de lectura de factura detalle
                    if (de.IdProducto == 0)
                        break;
                    if (de.Medida.IdMedidaMetrica == 0)
                        de.Medida.IdMedidaMetrica = 1;

                    facturaDetalles.Add(new FacturaDetalle
                    {
                        IDFacturaDetalle = rowDetalle++,
                        IDProducto = de.IdProducto,
                        Costo = Convert.ToDecimal(de.Precio),
                        Unidades = de.Unidades,
                        IDFactura = fac.IDFactura,
                        FechaSistema = DateTime.Now,
                        IdMedidaMetrica = de.Medida.IdMedidaMetrica,
                        IDKardex = rowKardex,
                        Iva = Convert.ToBoolean(de.IvaAplica)? Convert.ToInt16(General.Iva):0,
                        Estado = true,
                        Siclo="V"
                    });

                    //Obtenemos las compras
                    var listKardexCompras = (from a in repositoryKardex.Search(x => x.IDProducto == de.IdProducto)
                                             where a.Equivalencia > 0 && a.Movimiento!="F"
                                             select a).ToList();

                    foreach (Kardex item in listKardexCompras)
                    {
                        //obtenemos los valores negativo
                        long idFactura=0;
                        if (item.IDFactura.Contains(Compra))
                            idFactura = Convert.ToInt16(item.IDFactura.Remove(0, 1));
                        else
                            idFactura = Convert.ToInt16(item.IDFactura.Remove(0, 1));

                        //total del detalle
                        var total = repositoryKardex.Search(x => x.Referencia == idFactura && x.Equivalencia < 0).
                            Sum(x => x.Equivalencia);

                        //obtenemos las equivalencias de cantidades
                        var equivalencia = 0;
                        var p = new Repository<Producto>().Find(x => x.IDProducto == de.IdProducto);

                        if (de.Medida.Nivel != null && de.Medida.Nivel == 1)
                            equivalencia = Convert.ToInt16(p.Equivalencia1);

                        if (de.Medida.Nivel != null && de.Medida.Nivel == 2)
                            equivalencia = Convert.ToInt16(p.Equivalencia2);

                        if (total <= item.Equivalencia)
                        {
                            new CalculoUtilidad().Calcular(de.IdProducto, fac.IDFactura, Convert.ToInt16(de.Unidades), 
                                Convert.ToDecimal(de.Precio), (de.IvaAplica==true)?General.Iva:0,out kardices,
                                de.Medida.IdMedidaMetrica);
                            break;
                        }
                    }

                    //Actualizamos la existencia en el producto
                    var p1 = repositoryProducto.Find(x => x.IDProducto == de.IdProducto);
                    p1.ExistenciaActual = p1.ExistenciaActual - de.Unidades;

                    repositoryProducto.Update(p1);
                }

                repositoryDetalle.AddRange(facturaDetalles);
                if (!repositoryDetalle.Save())
                    throw new Exception(repositoryDetalle.Error);

                //actualizamos las faturas compras las existencias


                var parametros = new Repository<Parametros>();
                var nuFactura = parametros.Find(x => x.Station == 1);
                nuFactura.NumFactura = nuFactura.NumFactura + 1;
                parametros.Update(nuFactura);

                //Realizar Ajuste
                foreach (var a in detalle)
                    ajustes.Ajustar(a.IdProducto);

                ActualizaDatos(detalle);


            }
            catch (Exception ex)
            {
                //realizamos el rolbak
                repositoryDetalle.RemoveRange(facturaDetalles);
                repositoryKardex.RemoveRange(kardices);
                repositoryFactura.Remove(fac);

                Error = ex.Message.ToString();
                Result = false;
            }
            
            return Result;
        }

        public bool Devolucion(List<BillCore> detalle, long? IdFactura)
        {
            bool Result = true;

            
            var repositoryDetalle = new Repository<FacturaDetalle>();
            var repositoryKardex = new Repository<Kardex>();
            var repositoryProducto = new Repository<Producto>();
            //List<Kardex> detalle_ = new List<Kardex>();

            try
            {

                //grabamos el detalle
                int rowDetalle = repositoryDetalle.Count() + 1;
                int rowKardex = repositoryKardex.Count() + 1;

                foreach (BillCore de in detalle)
                {
                    //Control si en la siguiente linea de lectura de factura detalle
                    if (de.IdProducto == 0)
                        break;
                    if (de.Medida.IdMedidaMetrica == 0)
                        de.Medida.IdMedidaMetrica = 1;

                    facturaDetalles.Add(new FacturaDetalle
                    {
                        IDFacturaDetalle = rowDetalle++,
                        IDProducto = de.IdProducto,
                        Costo = Convert.ToDecimal(de.Precio),
                        Unidades = de.Unidades,
                        IDFactura = IdFactura,
                        FechaSistema = DateTime.Now,
                        IdMedidaMetrica = de.Medida.IdMedidaMetrica,
                        IDKardex = rowKardex,
                        Iva = Convert.ToBoolean(de.IvaAplica) ? Convert.ToInt16(General.Iva) : 0,
                        Estado = true
                    });

                    //Obtenemos las compras
                    var listKardexCompras = (from a in repositoryKardex.Search(x => x.IDProducto == de.IdProducto)
                                             where a.Equivalencia > 0 && a.Movimiento != "F"
                                             select a).ToList();

                    foreach (Kardex item in listKardexCompras)
                    {
                        //obtenemos los valores negativo
                        long idFactura = 0;
                        if (item.IDFactura.Contains(Compra))
                            idFactura = Convert.ToInt16(item.IDFactura.Remove(0, 1));
                        else
                            idFactura = Convert.ToInt16(item.IDFactura.Remove(0, 1));

                        //total del detalle
                        var total = repositoryKardex.Search(x => x.Referencia == idFactura && x.Equivalencia < 0).
                            Sum(x => x.Equivalencia);

                        //obtenemos las equivalencias de cantidades
                        var equivalencia = 0;
                        var p = new Repository<Producto>().Find(x => x.IDProducto == de.IdProducto);

                        if (de.Medida.Nivel != null && de.Medida.Nivel == 1)
                            equivalencia = Convert.ToInt16(p.Equivalencia1);

                        if (de.Medida.Nivel != null && de.Medida.Nivel == 2)
                            equivalencia = Convert.ToInt16(p.Equivalencia2);

                        if (total <= item.Equivalencia)
                        {
                            new CalculoUtilidad().Calcular(de.IdProducto, Convert.ToInt64(IdFactura), Convert.ToInt16(de.Unidades),
                                Convert.ToDecimal(de.Precio), (de.IvaAplica == true) ? General.Iva : 0, out kardices,
                                de.Medida.IdMedidaMetrica);

                            //rowKardex++;
                            break;
                        }
                    }

                    //Actualizamos la existencia en el producto
                    var p1 = repositoryProducto.Find(x => x.IDProducto == de.IdProducto);
                    p1.ExistenciaActual = p1.ExistenciaActual - de.Unidades;

                    repositoryProducto.Update(p1);
                }

                repositoryDetalle.AddRange(facturaDetalles);
                if (!repositoryDetalle.Save())
                    throw new Exception(repositoryDetalle.Error);


                var parametros = new Repository<Parametros>();
                var nuFactura = parametros.Find(x => x.Station == 1);
                nuFactura.NumFactura = nuFactura.NumFactura + 1;
                parametros.Update(nuFactura);

                //Realizar Ajuste
                foreach (var a in detalle)
                    ajustes.Ajustar(a.IdProducto);


            }
            catch (Exception ex)
            {
                //realizamos el rolbak
                repositoryDetalle.RemoveRange(facturaDetalles);
                repositoryKardex.RemoveRange(kardices);
                //repositoryFactura.Remove(fac);

                Error = ex.Message.ToString();
                Result = false;
            }

            return Result;
        }
        private void ActualizaDatos(List<BillCore> detalle)
        {
            Repository<FacturaDetalle> repository = new Repository<FacturaDetalle>();
            int? _Entra = 0;
            int? _Devolucion = 0;
            int? _Almacen = 0;

            for (int i=0; i< detalle.Count; i++)
            {
                _Entra = detalle[i].Unidades;

                long? IDp = detalle[i].IdProducto;

                var facturas = repository.Search(x =>x.IDProducto == IDp &&  (x.EnAlmacen>0 || x.EnDevolucion > 0)
                && (x.Siclo=="C" || x.Siclo == "I") && x.Estado==true);

                for(int j=0; j < facturas.Count; j++)
                {
                    _Devolucion = facturas[j].EnDevolucion;
                    _Almacen = facturas[j].EnAlmacen;

                    if (_Devolucion > 0)
                    {
                        _Entra = _Entra - _Devolucion;
                        if (_Entra < 0)
                        {
                            _Devolucion = _Devolucion - _Entra;
                            facturas[j].EnDevolucion = _Devolucion;
                            repository.Update(facturas[j]);
                            break;
                        }

                        //_Devolucion = 0;
                        facturas[j].EnDevolucion = null;
                        facturas[j].Movimiento = null;
                        
                        _Entra = _Entra - _Almacen;
                        if (_Entra < 0)
                        {
                            _Almacen = _Entra * -1;
                            facturas[j].EnAlmacen = _Almacen;
                            repository.Update(facturas[j]);
                            break;
                        }
                        _Almacen = 0;
                        facturas[j].EnAlmacen = _Almacen;

                        repository.Update(facturas[j]);
                    }
                    if (_Almacen > 0)
                    {
                        _Entra = _Entra - _Almacen;
                        if (_Entra < 0)
                        {
                            _Almacen = _Entra * -1;
                            facturas[j].EnAlmacen = _Almacen;
                            repository.Update(facturas[j]);
                            break;
                        }
                        _Almacen = 0;
                        facturas[j].EnAlmacen = _Almacen;
                        repository.Update(facturas[j]);
                    }
                }
            }
        }
    }
}
