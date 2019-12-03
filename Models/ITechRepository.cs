using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.Models
{
    interface ITechRepository
    {
        IEnumerable<Tech> AllTech { get; }
        IEnumerable<Tech> MostPopularTech { get; }
        Tech GetTechById(int techId);
    }
}
