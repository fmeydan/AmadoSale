//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AmadoFurniture.Areas.AdminPaneli
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonelMaaslari
    {
        public int PersonelMaaslarID { get; set; }
        public int PersonelID { get; set; }
        public decimal Maas { get; set; }
        public System.DateTime BaslamaTarihi { get; set; }
        public Nullable<System.DateTime> BitisTarihi { get; set; }
        public string Aciklama { get; set; }
    
        public virtual Personeller Personeller { get; set; }
    }
}
