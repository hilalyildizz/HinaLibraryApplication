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
    
    public partial class Kitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitap()
        {
            this.Odunc = new HashSet<Odunc>();
            this.Tur = new HashSet<Tur>();
            this.Yazar = new HashSet<Yazar>();
        }
    
        public long ISBNNo { get; set; }
        public string kod { get; set; }
        public string ad { get; set; }
        public Nullable<int> yayinEvi { get; set; }
        public Nullable<int> yayinYili { get; set; }
        public Nullable<int> kategori { get; set; }
        public string durum { get; set; }
    
        public virtual Kategori Kategori1 { get; set; }
        public virtual YayinEvi YayinEvi1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Odunc> Odunc { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tur> Tur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yazar> Yazar { get; set; }
    }
}
