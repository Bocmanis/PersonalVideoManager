using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVideoManager.Models
{
    public class Parent
    {
        public Guid SeasonalCollectionId { get; set; }
        public Guid SeasonId { get; set; }
        public Guid VideoId { get; set; }
    }
}
