﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class projectDBEntities5 : DbContext
    {
        public projectDBEntities5()
            : base("name=projectDBEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Business__tbl> Business__tbl { get; set; }
        public virtual DbSet<Category__tbl> Category__tbl { get; set; }
        public virtual DbSet<Events__tbl> Events__tbl { get; set; }
        public virtual DbSet<Schedule_tbl> Schedule_tbl { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users__tbl> Users__tbl { get; set; }
        public virtual DbSet<BusinessOpeningHours_tbl> BusinessOpeningHours_tbl { get; set; }
    }
}
