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
    
    public partial class Yorumlar
    {
        public int YorumlarID { get; set; }
        public int ParentYorumID { get; set; }
        public int UrunID { get; set; }
        public string Yorum { get; set; }
    
        public virtual Urunler Urunler { get; set; }
    }
}
