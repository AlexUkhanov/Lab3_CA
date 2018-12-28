using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CA
{
    class GenerateSet
    {
        Random rnd = new Random();
        private Item GenerateItem(int num)
        {
            return new Item("Вещь №" + num, rnd.Next(1, 5), rnd.Next(1000, 5000));
        }
        public List<Item> Generate()
        {
            List<Item> res = new List<Item>();
            int cnt = rnd.Next(5, 10);
            for (int i=0; i<cnt; i++)
            {
                res.Add(GenerateItem(i + 1));
            }
            return res;
        }
    }
}
