using dtc225180229bgn;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dtc225180229
{
    internal class Distributordbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=HP-PROBOOK\SQLEXPRESS;Database=npp1;Trusted_Connection=True;TrustServerCertificate=True;");

        }
        public DbSet<Distributor> distributors { get; set; }

    }
}

