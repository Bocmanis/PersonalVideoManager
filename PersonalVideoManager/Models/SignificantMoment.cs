﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalVideoManager.Models
{
    public class SignificantMoment
    {
        public double SkipFrom { get; set; }
        public double SkipTo { get; set; }
        public bool SkipThis { get; set; }
        public string Description { get; set; }
        public Parent Parent { get; set; }
    }
}
