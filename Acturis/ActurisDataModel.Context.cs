﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Acturis
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ACWEntities : DbContext
    {
        public ACWEntities()
            : base("name=ACWEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ClaimAmount> ClaimAmounts { get; set; }
        public virtual DbSet<ClaimCauseType> ClaimCauseTypes { get; set; }
        public virtual DbSet<ClaimCore> ClaimCores { get; set; }
        public virtual DbSet<ClaimReportField> ClaimReportFields { get; set; }
        public virtual DbSet<ClaimSection> ClaimSections { get; set; }
        public virtual DbSet<ClaimStatu> ClaimStatus { get; set; }
        public virtual DbSet<ClaimType> ClaimTypes { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Policy> Policies { get; set; }
        public virtual DbSet<LossInvolving> LossInvolvings { get; set; }
        public virtual DbSet<NatureOfInjury> NatureOfInjuries { get; set; }
        public virtual DbSet<NCBCompromised> NCBCompromiseds { get; set; }
        public virtual DbSet<ClaimAmountCategory> ClaimAmountCategories { get; set; }
        public virtual DbSet<ClaimHandler> ClaimHandlers { get; set; }
        public virtual DbSet<ClaimOffice> ClaimOffices { get; set; }
        public virtual DbSet<ClaimPayment> ClaimPayments { get; set; }
        public virtual DbSet<ClaimQueue> ClaimQueues { get; set; }
        public virtual DbSet<PolicySectionByType> PolicySectionByTypes { get; set; }
        public virtual DbSet<DataLoad> DataLoads { get; set; }
    }
}
