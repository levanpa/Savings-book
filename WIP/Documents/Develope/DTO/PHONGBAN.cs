//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication9.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHONGBAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHONGBAN()
        {
            this.GIAODICHVIENs = new HashSet<GIAODICHVIEN>();
        }
    
        public string MAPHONG { get; set; }
        public string DIADIEM { get; set; }
        public string TRGPHONG { get; set; }
        public Nullable<System.DateTime> NGAYNC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICHVIEN> GIAODICHVIENs { get; set; }
        public virtual GIAODICHVIEN GIAODICHVIEN { get; set; }
    }
}
