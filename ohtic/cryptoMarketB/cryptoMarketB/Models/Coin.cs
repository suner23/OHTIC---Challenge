using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cryptoMarketB.Models
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int MarketCap { get; set; }
        public int TotalSupply { get; set; }
        public int MaxSupply { get; set; }
        public List<Exchange> Exchanges { get; set; }
    }
}
