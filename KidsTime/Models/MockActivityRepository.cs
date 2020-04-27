using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsTime.Models
{
    public class MockActivityRepository : IActivityRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Activity> AllActivities =>
            new List<Activity>
            {
                new Activity{ActivityId=1, Name="Arta", ShortDescription="Descopera", LongDescription="Bucurie", Price=20, IsAvailable=true, IsActivityStar=true, Teacher="Sileanu Livius", Category = _categoryRepository.AllCategories.ToList()[2], ImageURl="https://cdn.pixabay.com/photo/2016/04/12/19/01/three-1325106_1280.png"},
                new Activity{ActivityId=2, Name="Stiinta", ShortDescription="Stiinta", LongDescription="Explorare", Price=25, IsAvailable=true, IsActivityStar=true, Teacher="Sileanu Ioan", Category = _categoryRepository.AllCategories.ToList()[1], ImageURl="https://cdn.pixabay.com/photo/2017/10/24/07/10/children-2883627_1280.jpg"},
                new Activity{ActivityId=3, Name="Dans", ShortDescription="Dans", LongDescription="Lectii de dans", Price=20, IsAvailable=true, IsActivityStar=true, Teacher="Sileanu Livius", Category = _categoryRepository.AllCategories.ToList()[0], ImageURl="https://cdn.pixabay.com/photo/2017/10/07/13/32/kids-2826512_1280.jpg"},
                new Activity{ActivityId=4, Name="Cultura", ShortDescription="Cultura", LongDescription="Cultura wordwide", Price=20, IsAvailable=true, IsActivityStar=true, Teacher="Sileanu Livius", Category = _categoryRepository.AllCategories.ToList()[0], ImageURl="https://cdn.pixabay.com/photo/2020/01/30/10/11/children-4804933_1280.jpg"},
            };

        public IEnumerable<Activity> IsActivityStar { get;}
        public Activity GetActivityById(int activityId)
        {
            return AllActivities.FirstOrDefault(p => p.ActivityId == activityId);
        }
    }
}
