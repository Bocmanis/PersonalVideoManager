using FastFoodDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Models
{
    public class SeasonalCollection: IHeadliner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public BindingList<Collection> Seasons { get; set; }
        public string Picture { get; set; }
        public bool IsHeadliner { get; set; }
    }
}
