using Microsoft.AspNetCore.Mvc.Rendering;
using SecondCharliesTechShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.ViewModels
{
    public class TechEditViewModel
    {
        public Tech Tech { get; set; }
        public List<SelectListItem> Categories { get; set; }
        public int CategoryId { get; set; }
    }
}
