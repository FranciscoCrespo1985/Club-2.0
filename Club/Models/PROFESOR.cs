//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Club.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PROFESOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PROFESOR()
        {
            this.ACTIVIDAD = new HashSet<ACTIVIDAD>();
        }
    
        public long ID_PROFESOR { get; set; }
        public string DNI { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string TELEFONO { get; set; }
        public string EMAIL { get; set; }
        public bool ESTADO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIVIDAD> ACTIVIDAD { get; set; }
    }
}