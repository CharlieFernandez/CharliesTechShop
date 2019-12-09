using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.Models
{
    public interface ITechRepository
    {
        IEnumerable<Tech> AllTech { get; }
        IEnumerable<Tech> MostPopularTech { get; }
        Tech GetTechById(int techId);
        void UpdateTech(Tech tech);
        void CreateTech(Tech tech);
    }
}
