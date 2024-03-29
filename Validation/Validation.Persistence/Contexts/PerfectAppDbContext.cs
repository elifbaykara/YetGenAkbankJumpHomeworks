﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validation.Domain.Entities;

namespace Validation.Persistence.Contexts
{
    public class PerfectAppDbContext:DbContext
    {
        public DbSet<BankAccount> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("PerfectApp");
        }
    }
}
