﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using LibrarySystem.Domain;

namespace LibrarySystem
{
    public class LibraryContext : DbContext
    {
        public DbSet<Title> Titles { get; set; }
        public DbSet<Copy> Copies { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Loan> Loans { get; set; }


         public LibraryContext()       // NOTE: LINQPad uses this!!!!
            : base()
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
