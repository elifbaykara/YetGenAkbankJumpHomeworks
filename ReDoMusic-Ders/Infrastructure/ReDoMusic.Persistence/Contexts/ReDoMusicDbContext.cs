using Microsoft.EntityFrameworkCore;
using ReDoMusic.Domain.Common;
using ReDoMusic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReDoMusic.Persistence.Contexts
{
    public class ReDoMusicDbContext : DbContext
    {
        public DbSet<Instrument> Instruments {  get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=91.151.83.102;Port=5432;Database=myDataBase;User Id=hakanamaratliteam;Password=oyi6IkdAQ*pL7qutMo4Q4FgpL;");
        }
    }
}
