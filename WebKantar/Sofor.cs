//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sofor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sofor()
        {
            this.Tartim = new HashSet<Tartim>();
        }
    
        public int SoforId { get; set; }
        public string SoforAd { get; set; }
        public string SoforSoyad { get; set; }
        public string SoforAdSoyad { get; set; }
        public string SoforTC { get; set; }
        public string SoforTelefon { get; set; }
        public Nullable<bool> Arsiv { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tartim> Tartim { get; set; }
    }
}