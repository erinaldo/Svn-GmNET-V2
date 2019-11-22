using Gm.Data;
using Gm.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gm.Core
{
    public static class ClaseAcceso
    {
        //Facturacion
        public static bool Factura_;
        public static bool FacturaGuardar_;
        public static bool FacturaImprimir_;
        public static bool FacturaCrearCliente_;
        public static bool FacturaEditarCliente_;
        public static bool FacturasEmitidas_;
        public static bool VentasRealizadasImprimirTodo_;
        public static bool VentasRealizadasImprimirSeleccion_;
        public static bool VentasRealizadasEliminarFactura_;
        public static bool VentasExportar_;

        //compras
        public static bool Compra_;
        public static bool CompraGuardar_;
        public static bool CompraCrearProducto_;
        public static bool CompraEditarProducto_;
        public static bool CompraCrearProveedor_;
        public static bool CompraEditarProveedor_;
        public static bool ComprasRealizadas_;
        public static bool ComprasRealizadasImprimirTodo_;
        public static bool ComprasRealizadasImprimirSeleccion_;
        public static bool ComprasRealizadasEliminarCompra_;

        //Producto
        public static bool Productos_;
        public static bool ProductosCrear_;
        public static bool ProductosEditar_;
        public static bool ProductosEliminar_;
        public static bool ProductosExporta_;
        public static bool ProductosEdicionRapida_;
        public static bool ProductosRestablecer_;
        public static bool ProductosQuitarMarcas_;
        public static bool ProductosInventarioInicial_;
        public static bool ProductosTraslado_;
        public static bool ComprasExportar_;

        //bodega

        //cuentas por cobrar
        public static bool CuentasporCobrar_;
        public static bool CuentasporCobrarNuevoAbono_;
        public static bool CuentasporCobrarEliminarAbono_;
        public static bool CuentasporCobrarEditarAbono_;
        public static bool CuentasporCobrarExportar_;

        //Reportes
        public static bool ConsultasReportes_;
        public static bool VentasRealizadas_;
        public static bool ComprasvsVentas_;
        public static bool MovimientoProducto_;
        public static bool EstadisticaProducto_;
        
        //abrir caja
        public static bool AbrirCaja_;
        
        //Clientes
        public static bool Clientes_;
        public static bool ClientesCrear_;
        public static bool ClientesEditar_;
        public static bool ClienteEliminar_;

        //Proveedor
        public static bool Proveedores_;
        public static bool ProveedoresCrear_;
        public static bool ProveedoresEditar_;
        public static bool ProveedorEliminar_;

        //usuarios
        public static bool Usuarios_;
        public static bool UsuariosNuevo_;
        public static bool UsuariosEditar_;
        public static bool UsuariosEliminar_;

        //Administracion
        public static bool Administracion_;

        public static bool Computadoras_;
        public static bool ComputadorasNuevo_;
        public static bool ComputadorasEditar_;
        public static bool ComputadorasEliminar_;

        public static bool Categoria_;
        public static bool CategoriaNuevo_;
        public static bool CategoriaEditar_;
        public static bool CategoriaEliminar_;

        public static bool Medidas_;
        public static bool MedidasNuevo_;
        public static bool MedidasEditar_;
        public static bool MedidasEliminar_;

        public static bool Marcas_;
        public static bool MarcasNuevo_;
        public static bool MarcasEditar_;
        public static bool MarcasEliminar_;
        
        public static bool DisenioReporte_;
        public static bool CambiarConexion_;
        public static bool CopiadeSeguridad_;
        public static bool Estilos_;

        public static bool PonerenReserva_;
        public static bool BuscarReserva_;
        public static bool Modulos_;
        public static bool ModulosNuevo_;
        public static bool ModulosEditar_;
        public static bool ModulosEliminar_;

        
        

        
        

        
    }
}
