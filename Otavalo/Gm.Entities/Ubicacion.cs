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
    
    public partial class Ubicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ubicacion()
        {
            this.Producto = new HashSet<Producto>();
        }
    
        public long IDUbicacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public Nullable<bool> Estado { get; set; }
        public Nullable<long> IDUsuario { get; set; }
        public Nullable<System.DateTime> FechaSystema { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Producto> Producto { get; set; }
    }
}
