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
    
    public partial class STK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STK()
        {
            this.CAPNHATs = new HashSet<CAPNHAT>();
        }
    
        public string MASTK { get; set; }
        public string MAKH { get; set; }
        public string MALOAITK { get; set; }
        public Nullable<System.DateTime> NGAYMO { get; set; }
        public Nullable<System.DateTime> NGAYBD { get; set; }
        public Nullable<System.DateTime> NGAYDH { get; set; }
        public Nullable<double> SODU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAPNHAT> CAPNHATs { get; set; }
        public virtual KHACHHANG KHACHHANG { get; set; }
        public virtual LOAITK LOAITK { get; set; }
    }
}
