//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ürün_Satış_Takip_Programı
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLKATAGORİ
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKATAGORİ()
        {
            this.TBLURUN = new HashSet<TBLURUN>();
        }
    
        public int ID { get; set; }
        public string AD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLURUN> TBLURUN { get; set; }
    }
}
