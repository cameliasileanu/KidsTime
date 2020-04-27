using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsTime.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string Teacher { get; set; }
        public decimal Price { get; set; }
        public string ImageURl { get; set; }
        public string ImageThumbnailURl { get; set; }
        public bool IsActivityStar { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int PhoneNumber { get; set; }


    }
}
