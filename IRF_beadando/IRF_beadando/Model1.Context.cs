﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IRF_beadando
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database2Entities : DbContext
    {
        public Database2Entities()
            : base("name=Database2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Edzo> Edzoes { get; set; }
        public virtual DbSet<Eredmeny> Eredmenies { get; set; }
        public virtual DbSet<Sportolo> Sportoloes { get; set; }
    }
}
