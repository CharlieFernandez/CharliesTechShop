using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.Auth
{
    public class CharliesTechShopClaimTypes
    {
        public static List<string> ClaimsList { get; set; } = new List<string> { "Delete Tech", "Add Tech", "Age for ordering" };
    }
}
