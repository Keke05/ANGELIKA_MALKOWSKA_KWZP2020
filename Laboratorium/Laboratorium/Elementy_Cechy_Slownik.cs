//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorium
{
    using System;
    using System.Collections.Generic;
    
    public partial class Elementy_Cechy_Slownik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Elementy_Cechy_Slownik()
        {
            this.Elementy_Cechy = new HashSet<Elementy_Cechy>();
        }
    
        public int ID_Cecha { get; set; }
        public string Cecha { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Elementy_Cechy> Elementy_Cechy { get; set; }
    }
}
