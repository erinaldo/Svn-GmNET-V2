using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Gm.Data;
using Gm.Entities;

namespace Gm.Core
{
    public class ParametrosBLL
    {
        public float myIva
        {
            get;
            private set;
        }

        public string numFactura
        {
            get;
            private set;
        }

        public long numSucursal
        {
            get;
            private set;
        }
        public Image myFoto
        {
            get;
            private set;
        }
        public ParametrosBLL()
        {
            var resp = new Repository<Parametros>().Find(x => x.Station == 1);
            if (resp != null)
            {
                myIva = Convert.ToInt16(resp.Iva);
                numSucursal = resp.Station;
                numFactura = String.Format("{0:0000000000}", Convert.ToInt32(resp.NumFactura));
                if(resp.Foto!=null  && resp.Foto.Length>0)
                    myFoto = TratadoImagen.Convertir_Bytes_Imagen(resp.Foto);
            }
            
        }
    }
}
