using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVideoManager.Models
{
    public class Video
    {
        public Guid Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public List<SignificantMoment> TimeSkips { get; set; }
        public Parent Parent { get; set; }
    }
}
