using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PriceWeb.Models
{
    public class Stockstate
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string PharmacyId { get; set; }
        public Decimal OnStock { get; set; }
    }
}
