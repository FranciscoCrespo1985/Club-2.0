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
    
    public partial class LOCACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOCACION()
        {
            this.HORARIO = new HashSet<HORARIO>();
        }
    
        public int ID_LOCACION { get; set; }
        public string DESCRIPCION { get; set; }
        public int ID_TIPO_ACTIVIDAD { get; set; }
        public bool ESTADO { get; set; }
    
        public virtual ACTIVIDAD_TIPO ACTIVIDAD_TIPO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HORARIO> HORARIO { get; set; }
    }
}