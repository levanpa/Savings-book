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
    
    public partial class QUAYGD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUAYGD()
        {
            this.GIAODICHes = new HashSet<GIAODICH>();
        }
    
        public string MAQUAY { get; set; }
        public string TENQUAY { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAODICH> GIAODICHes { get; set; }
    }
}
