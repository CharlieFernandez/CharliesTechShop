using SecondCharliesTechShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.ViewModels
{
    public class TechListViewModel
    {
        public IEnumerable<Tech> Tech { get; set; }
        public string CurrentCategory { get; set; }
    }
}
