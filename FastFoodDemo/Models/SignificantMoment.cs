using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Models
{
    public class SignificantMoment
    {
        public long SkipFrom { get; set; }
        public long SkipTo { get; set; }
        public bool SkipThis { get; set; }
        public string Description { get; set; }
        public Parent Parent { get; set; }
    }
}
