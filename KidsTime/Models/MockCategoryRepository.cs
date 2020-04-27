using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsTime.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Artistice", Description="Arta pentru creier si suflet"},
                new Category{CategoryId=1, CategoryName="Culturale", Description="Cultura pentru creier si suflet"},
                new Category{CategoryId=1, CategoryName="Stiintifice", Description="Stiinita pentru creier si suflet"},
                new Category{CategoryId=1, CategoryName="Sportive", Description="Sport pentru trup si suflet"},
            };
    }
}
