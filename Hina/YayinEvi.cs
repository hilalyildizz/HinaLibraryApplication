//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hina
{
    using System;
    using System.Collections.Generic;
    
    public partial class YayinEvi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public YayinEvi()
        {
            this.Kitap = new HashSet<Kitap>();
        }
    
        public int yayineviNo { get; set; }
        public string ad { get; set; }
        public Nullable<int> telefonNo { get; set; }
        public Nullable<int> adres { get; set; }
        public string webSite { get; set; }
    
        public virtual Adres Adres1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kitap> Kitap { get; set; }
    }
}