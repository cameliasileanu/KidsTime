using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsTime.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<Activity> Activities { get; set; }
    }
}
