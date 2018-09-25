﻿using DemoBlazorMspTechDays.Shared;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoBlazorMspTechDays.Server.Data
{
    public class CodingNightContext : DbContext
    {
        public CodingNightContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Contato> Contatos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contato>()
                .HasKey(p => p.Id);
        }
    }
}
