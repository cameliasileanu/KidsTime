using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsTime.Models
{
    public class ActivityRepository :IActivityRepository
    {
        private readonly AppDbContext _appDbContext;
        public ActivityRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Activity> AllActivities
        {
            get
            {
                return _appDbContext.Activities.Include(c=>c.Category);
            }
        }

        public IEnumerable<Activity> IsActivityStar
        {
            get
            {
                return _appDbContext.Activities.Include(c => c.Category).Where(a => a.IsActivityStar); ;
            }
        }

        public Activity GetActivityById(int activityId)
            {
                return _appDbContext.Activities.FirstOrDefault(a => a.ActivityId == activityId);
            }
        }
}
