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
    
    public partial class HoatDongCoSo
    {
        public int MaHoatDong { get; set; }
        public string MaCoSo { get; set; }
        public Nullable<System.DateTime> NgayDBDatBan { get; set; }
        public Nullable<System.DateTime> NgayKTDatBan { get; set; }
    
        public virtual CoSo CoSo { get; set; }
        public virtual HoatDong HoatDong { get; set; }
    }
}
