﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCDApplication.Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TCDEntities1 : DbContext
    {
        public TCDEntities1()
            : base("name=TCDEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_CustomerDetails> tbl_CustomerDetails { get; set; }
        public virtual DbSet<tbl_CustomerDocuments> tbl_CustomerDocuments { get; set; }
        public virtual DbSet<tbl_CustomerFlatDetails> tbl_CustomerFlatDetails { get; set; }
        public virtual DbSet<tbl_CustomerTransactionDetails> tbl_CustomerTransactionDetails { get; set; }
        public virtual DbSet<tbl_ProjectDetails> tbl_ProjectDetails { get; set; }
        public virtual DbSet<tbl_Login> tbl_Login { get; set; }
    }
}
