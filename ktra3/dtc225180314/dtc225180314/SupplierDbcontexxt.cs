
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace dtc225180314
{
    internal class SupplierDbcontexxt : DbContext
    {
      
        
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=HP-PROBOOK\SQLEXPRESS;Database=ncc;Trusted_Connection=True;TrustServerCertificate=True;");

            }
            public DbSet<Supplier> suppliers { get; set; }

        
    }
}
