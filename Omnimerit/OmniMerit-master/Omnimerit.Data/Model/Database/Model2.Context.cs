﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Omnimerit.Data.Model.Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OmnimeritEntities1 : DbContext
    {
        public OmnimeritEntities1()
            : base("name=OmnimeritEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Circular> Circulars { get; set; }
        public virtual DbSet<AccountGroup> AccountGroups { get; set; }
        public virtual DbSet<FeeCategory> FeeCategories { get; set; }
        public virtual DbSet<LessonPlanning> LessonPlannings { get; set; }
        public virtual DbSet<TransportAllocationDetail> TransportAllocationDetails { get; set; }
    }
}
