using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CA
{
    public class Item
    {
        public double Cost { get; set; }
        public double Weight { get; set; }
        public string Name { get; set; }

        public Item(string name_in,double weight_in,double cost_in)
        {
            Name = name_in;
            Weight = weight_in;
            Cost = cost_in;
        }
    }
}
