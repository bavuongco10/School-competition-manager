﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HoatDongUEHEntities : DbContext
    {
        public HoatDongUEHEntities()
            : base("name=HoatDongUEHEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ConNguoi> ConNguois { get; set; }
        public virtual DbSet<ConNguoiLop> ConNguoiLops { get; set; }
        public virtual DbSet<CoSo> CoSoes { get; set; }
        public virtual DbSet<DonVi> DonVis { get; set; }
        public virtual DbSet<HoatDong> HoatDongs { get; set; }
        public virtual DbSet<HoatDongConNguoi> HoatDongConNguois { get; set; }
        public virtual DbSet<HoatDongCoSo> HoatDongCoSoes { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<NhomHoatDong> NhomHoatDongs { get; set; }
        public virtual DbSet<NienKhoa> NienKhoas { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<VaiTro> VaiTroes { get; set; }
        public virtual DbSet<HoatDongCuocThiHot> HoatDongCuocThiHots { get; set; }
        public virtual DbSet<HoatDongCuocThiOnGoing> HoatDongCuocThiOnGoings { get; set; }
        public virtual DbSet<DangNhap> DangNhaps { get; set; }
    }
}
