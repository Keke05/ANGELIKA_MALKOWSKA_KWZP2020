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
    
    public partial class Kurierzy
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kurierzy()
        {
            this.Umowy_Kurierzy = new HashSet<Umowy_Kurierzy>();
        }
    
        public int ID_Kurier { get; set; }
        public string Nazwa { get; set; }
        public Nullable<int> Telefon_1 { get; set; }
        public Nullable<int> Telefon_2 { get; set; }
        public string Email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Umowy_Kurierzy> Umowy_Kurierzy { get; set; }
    }
}
