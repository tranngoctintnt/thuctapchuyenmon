//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entities_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class HD_BanHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HD_BanHang()
        {
            this.CTHD_BanHang = new HashSet<CTHD_BanHang>();
        }
    
        public int ma_HD { get; set; }
        public Nullable<int> ma_KH { get; set; }
        public Nullable<int> ma_NV { get; set; }
        public Nullable<System.DateTime> ngaylap_HD { get; set; }
        public Nullable<bool> isDelete { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD_BanHang> CTHD_BanHang { get; set; }
        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
