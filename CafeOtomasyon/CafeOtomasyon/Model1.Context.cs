﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CafeOtomasyon
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ErtasCafeOtomasyonuEntities1 : DbContext
    {
        public ErtasCafeOtomasyonuEntities1()
            : base("name=ErtasCafeOtomasyonuEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Kullanici> tbl_Kullanici { get; set; }
        public virtual DbSet<tbl_Masa1> tbl_Masa1 { get; set; }
        public virtual DbSet<tbl_Masa2> tbl_Masa2 { get; set; }
        public virtual DbSet<tbl_Masa3> tbl_Masa3 { get; set; }
        public virtual DbSet<tbl_Masa4> tbl_Masa4 { get; set; }
        public virtual DbSet<tbl_Masa5> tbl_Masa5 { get; set; }
        public virtual DbSet<tbl_Masa6> tbl_Masa6 { get; set; }
        public virtual DbSet<tbl_Masa7> tbl_Masa7 { get; set; }
        public virtual DbSet<tbl_Masa8> tbl_Masa8 { get; set; }
        public virtual DbSet<tbl_Menu> tbl_Menu { get; set; }
    }
}
