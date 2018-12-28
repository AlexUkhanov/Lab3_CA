using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CA
{
    class Item
    {
        public double Cost { get; set; }
        public double Weigth { get; set; }
        public string Name { get; set; }

        public Item(string name_in,double weigth_in,double cost_in)
        {
            Name = name_in;
            Weigth = weigth_in;
            Cost = cost_in;
        }
    }
}
