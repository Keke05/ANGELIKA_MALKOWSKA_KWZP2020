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
    
    public partial class Jezyk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Jezyk()
        {
            this.Znajomosc_Jezykow = new HashSet<Znajomosc_Jezykow>();
        }
    
        public int ID_Jezyk { get; set; }
        public string Jezyk1 { get; set; }
        public string Informacje_Dodatkowe { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Znajomosc_Jezykow> Znajomosc_Jezykow { get; set; }
    }
}
