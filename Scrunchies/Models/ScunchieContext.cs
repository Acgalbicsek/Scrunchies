using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Scrunchies.Models
{
    internal class ScunchieContext 
    {

        public DbSet<Product> Product { get; set; }
        public DbSet<Sales> Sales { get; set; }
        public DbSet<Stock> ProductStock { get; set; }

    }
}
