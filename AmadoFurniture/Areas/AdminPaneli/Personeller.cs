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
    
    public partial class Personeller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personeller()
        {
            this.PersonelMaaslari = new HashSet<PersonelMaaslari>();
        }
    
        public int PersonellerID { get; set; }
        public string PersonelTC { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Cinsiyeti { get; set; }
        public string Telefonu { get; set; }
        public string MailAdresi { get; set; }
        public string Bolumu { get; set; }
        public string Adresi { get; set; }
        public Nullable<System.DateTime> GirisTarihi { get; set; }
        public Nullable<bool> Aktifmi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonelMaaslari> PersonelMaaslari { get; set; }
    }
}
