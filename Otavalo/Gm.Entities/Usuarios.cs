//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Gm.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Usuarios()
        {
            this.Credito = new HashSet<Credito>();
            this.Traslados = new HashSet<Traslados>();
        }
    
        public long IDUsuario { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Login { get; set; }
        public string Pasword { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<bool> CCodBarra { get; set; }
        public Nullable<bool> CIvaA { get; set; }
        public Nullable<bool> CPCAnterior { get; set; }
        public Nullable<bool> CPv2A { get; set; }
        public Nullable<bool> CPv3A { get; set; }
        public Nullable<bool> CEqui1A { get; set; }
        public Nullable<bool> CEqui2A { get; set; }
        public Nullable<bool> CEqui3A { get; set; }
        public Nullable<bool> CActivo2A { get; set; }
        public Nullable<bool> CActivo3A { get; set; }
        public Nullable<bool> CUltimaCompraA { get; set; }
        public Nullable<bool> CPrecioAnteriorVenta1 { get; set; }
        public Nullable<bool> CPrecioAnteriorVenta2 { get; set; }
        public Nullable<bool> CPrecioAnteriorVenta3 { get; set; }
        public Nullable<bool> CNombreAnterior { get; set; }
        public Nullable<bool> CCodigoRapido { get; set; }
        public Nullable<bool> CExistenciaMinima { get; set; }
        public Nullable<bool> CMarca { get; set; }
        public Nullable<bool> CCategoria { get; set; }
        public Nullable<bool> CEstado { get; set; }
        public Nullable<bool> CExistenciaActual { get; set; }
        public Nullable<bool> CFotoProducto { get; set; }
        public Nullable<bool> CUltimaVentaA { get; set; }
        public Nullable<bool> CPAnterior { get; set; }
        public Nullable<bool> CNotificar { get; set; }
        public Nullable<bool> CMostraNotificar { get; set; }
        public Nullable<bool> CFechaExpiracion { get; set; }
        public Nullable<bool> CEnBodega { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Credito> Credito { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Traslados> Traslados { get; set; }
    }
}
