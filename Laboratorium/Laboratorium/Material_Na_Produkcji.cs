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
    
    public partial class Material_Na_Produkcji
    {
        public int ID_Material_Na_Produkcji { get; set; }
        public int ID_Procesu_Produkcyjnego { get; set; }
        public int ID_Element { get; set; }
        public double Liczba { get; set; }
        public int ID_Jednostka { get; set; }
        public Nullable<double> Odpad { get; set; }
    
        public virtual Elementy Elementy { get; set; }
        public virtual Elementy_Jednostki Elementy_Jednostki { get; set; }
        public virtual Proces_Produkcyjny Proces_Produkcyjny { get; set; }
    }
}
