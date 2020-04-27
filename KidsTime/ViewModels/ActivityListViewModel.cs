using KidsTime.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsTime.ViewModels
{
    public class ActivityListViewModel
    {
        public IEnumerable<Activity> Activities { get; set; }
        public string CurrentCategory { get; set; }
    }
}
