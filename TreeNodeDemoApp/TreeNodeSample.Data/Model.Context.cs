﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TreeNodeSample.Data
{
    using System;
    using System.Data.Entity;
    using TreeNodeSample.Model;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TestDBEntities : DbContext
    {
        public TestDBEntities()
            : base("name=TestDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CountryBettingTax> CountryBettingTaxes { get; set; }
        public virtual DbSet<TaxEntity> TaxEntities { get; set; }
    
        public virtual ObjectResult<string> GetCountryBettingTax(Nullable<int> countryId)
        {
            var countryIdParameter = countryId.HasValue ?
                new ObjectParameter("CountryId", countryId) :
                new ObjectParameter("CountryId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetCountryBettingTax", countryIdParameter);
        }
    }
}
