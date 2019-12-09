using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.Models
{
    public class TechRepository: ITechRepository
    {
        private readonly AppDbContext _appDbContext;

        public TechRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Tech> AllTech
        {
            get
            {
                return _appDbContext.Tech.Include(t => t.Category);
            }
        }

        public IEnumerable<Tech> MostPopularTech
        {
            get
            {
                return _appDbContext.Tech.Include(t => t.Category).Where(t => t.PopularTech == true);
            }
        }

        public Tech GetTechById(int techId)
        {
            return _appDbContext.Tech.FirstOrDefault(t => t.TechId == techId);
        }

        public void UpdateTech(Tech tech)
        {
            _appDbContext.Tech.Update(tech);
            _appDbContext.SaveChanges();
        }

        public void CreateTech(Tech tech)
        {
            _appDbContext.Tech.Add(tech);
            _appDbContext.SaveChanges();
        }
    }
}
