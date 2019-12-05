using SecondCharliesTechShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Tech> MostPopularTech { get; set; }
    }
}
