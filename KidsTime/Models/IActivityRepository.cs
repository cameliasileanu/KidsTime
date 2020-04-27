using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsTime.Models
{
    public interface IActivityRepository
    {
        IEnumerable<Activity>AllActivities { get;}
        IEnumerable<Activity> IsActivityStar { get; }
        Activity GetActivityById(int activityId);
    }
}
