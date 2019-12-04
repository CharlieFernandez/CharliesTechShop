using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondCharliesTechShop.Models
{
    public class MockTechRepository: ITechRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Tech> AllTech =>
            new List<Tech>
            {
                new Tech {TechId = 1, Name="Strawberry Pie", Price=15.95M, Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg", InStock=true, PopularTech=false},
                new Tech {TechId = 2, Name="Cheese cake", Price=18.95M, Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg", InStock=true, PopularTech=false},
                new Tech {TechId = 3, Name="Rhubarb Pie", Price=15.95M, Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg", InStock=true, PopularTech=true},
                new Tech {TechId = 4, Name="Pumpkin Pie", Price=12.95M, Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg", InStock=true, PopularTech=true}
            };

        public IEnumerable<Tech> PiesOfTheWeek { get; }

        public IEnumerable<Tech> MostPopularTech => throw new NotImplementedException();

        public Tech GetTechById(int techId)
        {
            return AllTech.FirstOrDefault(t => t.TechId == techId);
        }
    }
}
