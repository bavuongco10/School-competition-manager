//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOP
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConNguoi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ConNguoi()
        {
            this.ConNguoiLops = new HashSet<ConNguoiLop>();
            this.HoatDongConNguois = new HashSet<HoatDongConNguoi>();
        }
    
        public int MaConNguoi { get; set; }
        public string MaSinhVien { get; set; }
        public string HoChuLot { get; set; }
        public string Ten { get; set; }
        public Nullable<int> MaNienKhoa { get; set; }
        public Nullable<bool> GioiTinh { get; set; }
        public Nullable<System.DateTime> NgaySinh { get; set; }
        public string NoiSinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual NienKhoa NienKhoa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConNguoiLop> ConNguoiLops { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoatDongConNguoi> HoatDongConNguois { get; set; }
    }
}
