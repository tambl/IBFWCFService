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
    
    public partial class IBFEntities : DbContext
    {
        public IBFEntities()
            : base("name=IBFEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<PolicyReinsurance> PolicyReinsurances { get; set; }
        public virtual DbSet<PolicyVersion> PolicyVersions { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<LegalStatu> LegalStatus { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<AgentBroker> AgentBrokers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<SubProduct> SubProducts { get; set; }
        public virtual DbSet<ReinsuranceContract> ReinsuranceContracts { get; set; }
        public virtual DbSet<ProductType> ProductTypes { get; set; }
        public virtual DbSet<PolicyStatu> PolicyStatus { get; set; }
        public virtual DbSet<PolicyVersionStatu> PolicyVersionStatus { get; set; }
    }
}
