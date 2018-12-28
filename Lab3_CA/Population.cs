using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CA
{
    public class Population
    {
        Knapsack[] sacs;

        // Construct a population
        public Population(int populationSize, bool initialise)
        {
            sacs = new Knapsack[populationSize];

            if (initialise)
            {
                // Loop and create individuals
                for (int i = 0; i < populationSize; i++)
                {
                    Knapsack newSacs = new Knapsack();
                    newSacs.generateIndividual();
                    saveSac(i, newSacs);
                }
            }
        }

        // Saves a tour
        public void saveSac(int index, Knapsack sac)
        {
            sacs[index] = sac;
        }

        // Gets a tour from population
        public Knapsack getSac(int index)
        {
            return sacs[index];
        }

        // Gets the best tour in the population
        public Knapsack getFittest()
        {
            Knapsack fittest = sacs[0];
            for (int i = 1; i < populationSize(); i++)
            {
                if (fittest.getFitness() <= getSac(i).getFitness())
                {
                    fittest = getSac(i);
                }
            }

            return fittest;
        }

        // Gets population size
        public int populationSize()
        {
            return sacs.Length;
        }
    }

}
