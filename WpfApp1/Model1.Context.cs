﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Test1Entities : DbContext
    {
        public Test1Entities()
            : base("name=Test1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Checking> Checking { get; set; }
        public virtual DbSet<Coating> Coating { get; set; }
        public virtual DbSet<Drying> Drying { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Goods> Goods { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Parts> Parts { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Realisation> Realisation { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Workshop> Workshop { get; set; }
        public virtual DbSet<Build> Build { get; set; }
    }
}
