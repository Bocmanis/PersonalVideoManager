using FastFoodDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Models
{
    public class Collection: IHeadliner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BindingList<Video> Videos { get; set; }
        public string Picture { get; set; }
        public bool IsHeadliner { get; set; }
        public Parent Parent { get; set; }
    }
}
