//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KutuphaneOtm.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uye
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Uye()
        {
            this.Emanetler = new HashSet<Emanetler>();
        }
    
        public int UyeID { get; set; }
        public string UyeAd { get; set; }
        public string UyeSoyad { get; set; }
        public Nullable<int> UyeTelefon { get; set; }
        public string UyeEposta { get; set; }
        public string UyeAdres { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Emanetler> Emanetler { get; set; }
    }
}