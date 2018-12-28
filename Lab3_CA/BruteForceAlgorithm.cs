using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CA
{
    class BruteForceAlgorithm
    {
        private List<Item> bestCombination;
        private double maxWeight;
        private double bestCost;
        public long timeWork =0;

        public BruteForceAlgorithm(double cap_in)
        {
            maxWeight = cap_in;
        }

        //Get summary weight from this List<Item> it
        private double GetSummaryWeightFromItems(List<Item> it)
        {
            double res = 0;
            foreach(Item i in it)
            {
                res += i.Weight;
            }
            return res;
        }

        //Get summary cost from this List<Item> it
        private double GetSummaryCostFromItems(List<Item> it)
        {
            double res = 0;
            foreach (Item i in it)
            {
                res += i.Cost;
            }
            return res;
        }

        //check for the best solution
        private void CheckSet(List<Item> items)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            if (bestCombination == null)
            {
                if (GetSummaryWeightFromItems(items) <= maxWeight)
                {
                    bestCombination = items;
                    bestCost = GetSummaryCostFromItems(items);
                }
            }
            else
            {
                if (GetSummaryWeightFromItems(items) <= maxWeight && GetSummaryCostFromItems(items) > bestCost)
                {
                    bestCombination = items;
                    bestCost = GetSummaryCostFromItems(items);
                }
            }

            sw.Stop();
            timeWork = sw.ElapsedTicks;
        }

        //creates all transpositions (recursion)
        public void MakeAllSets(List<Item> items)
        {
            if (items.Count > 0)
                CheckSet(items);
            for (int i=0; i < items.Count; i++)
            {
                List<Item> newSet = new List<Item>(items);
                newSet.RemoveAt(i);
                MakeAllSets(newSet);
            }
        }

        public List<Item> GetBest()
        {
            return bestCombination;
        }
    }
}
