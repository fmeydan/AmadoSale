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
    
    public partial class UrunStoklari
    {
        public int UrunStoklarID { get; set; }
        public int UrunID { get; set; }
        public int StokMiktari { get; set; }
        public System.DateTime AlinisTarihi { get; set; }
        public decimal AlisFiyati { get; set; }
        public int TedarikID { get; set; }
    
        public virtual Tedarikciler Tedarikciler { get; set; }
        public virtual Urunler Urunler { get; set; }
    }
}
