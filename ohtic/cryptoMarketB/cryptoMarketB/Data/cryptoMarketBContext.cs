using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cryptoMarketB.Models;

namespace cryptoMarketB.Data
{
    public class cryptoMarketBContext : DbContext
    {
        public cryptoMarketBContext (DbContextOptions<cryptoMarketBContext> options)
            : base(options)
        {
        }

        public DbSet<cryptoMarketB.Models.Exchange> Exchange { get; set; }

        public DbSet<cryptoMarketB.Models.Coin> Coin { get; set; }
    }
}
