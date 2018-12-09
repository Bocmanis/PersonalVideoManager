using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFoodDemo.Interfaces
{
    public interface IHeadliner
    {
        string Name { get; set; }
        string Picture { get; set; }
        bool IsHeadliner { get; set; }
    }
}
