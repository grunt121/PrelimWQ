﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PrelimWQ.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PrelimMailEntities : DbContext
    {
        public PrelimMailEntities()
            : base("name=PrelimMailEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<MailParticipant> MailParticipants { get; set; }
        public virtual DbSet<MailRespons> MailResponses { get; set; }
        public virtual DbSet<MailResponseType> MailResponseTypes { get; set; }
        public virtual DbSet<MailResponseConsent> MailResponseConsents { get; set; }
    }
}