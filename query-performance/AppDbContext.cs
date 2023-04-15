using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryPerformance
{
    public class AppDbContext : DbContext
    {
        public DbSet<Province> Province { get; set; } = null!;
        public DbSet<District> District { get; set; } = null!;
        public DbSet<Ward> Ward { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=CT-COMPUTER;Initial Catalog=SDP;Integrated Security=True;TrustServerCertificate=true;");
        }

    }
}
