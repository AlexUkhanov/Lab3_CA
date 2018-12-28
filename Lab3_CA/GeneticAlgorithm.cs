using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_CA
{
    /*
    * Manages algorithms for evolving population
    */
    public class GeneticAlgorithm
    {

        /* GA parameters */
        private static double mutationRate = 0.015;
        private static int tournamentSize = 5;
        private static bool elitism = true;

        // Evolves a population over one generation
        public static Population evolvePopulation(Population pop)
        {
            Population newPopulation = new Population(pop.populationSize(), false);

            // Keep our best individual if elitism is enabled
            int elitismOffset = 0;
            if (elitism)
            {
                newPopulation.saveSac(0, pop.getFittest());
                elitismOffset = 1;
            }

            // Crossover population
            // Loop over the new population's size and create individuals from
            // Current population
            for (int i = elitismOffset; i < newPopulation.populationSize(); i++)
            {
                // Select parents
                Knapsack parent1 = tournamentSelection(pop);
                Knapsack parent2 = tournamentSelection(pop);
                // Crossover parents
                Knapsack child = crossover(parent1, parent2);
                // Add child to new population
                newPopulation.saveSac(i, child);
            }

            // Mutate the new population a bit to add some new genetic material
            for (int i = elitismOffset; i < newPopulation.populationSize(); i++)
            {
                mutate(newPopulation.getSac(i));
            }

            return newPopulation;
        }

        // Applies crossover to a set of parents and creates offspring
        public static Knapsack crossover(Knapsack parent1, Knapsack parent2)
        {
            Random rnd = new Random();
            // Create new child tour
            Knapsack child = new Knapsack();

            // Get start and end sub tour positions for parent1's tour
            int crossPos = (int)(rnd.NextDouble()* parent1.getObjects().Length);

            // Loop and add the sub tour from parent1 to our child
            for (int i = 0; i < child.getObjects().Length; i++)
            {
                if (i < crossPos)
                {
                    child.processWeight();
                    if (child.getWeight() + MainForm.listItems[i].Weight <= child.getCapacity())
                    {
                        child.setoneObject(i, parent2.getoneObject(i));
                        child.processWeight();
                    }

                }
                else
                {
                    child.processWeight();
                    if (child.getWeight() + MainForm.listItems[i].Weight <= child.getCapacity())
                    {
                        child.setoneObject(i, parent1.getoneObject(i));
                        child.processWeight();
                    }
                }
            }




            child.processValue();
            return child;
        }

        // Mutate a tour using swap mutation
        private static void mutate(Knapsack sac)
        {
            Random rnd = new Random();
            // Loop through tour cities
            for (int i = 0; i < sac.getObjects().Length; i++)
            {
                // Apply mutation rate
                if (rnd.NextDouble() < mutationRate)
                {
                    // Get a second random position in the tour
                    int mutationPos = (int)(sac.getObjects().Length * rnd.NextDouble());
                    if (sac.getObjects()[mutationPos])
                    {
                        sac.setoneObject(i, false);
                        sac.processValue();
                        sac.processWeight();
                    }
                    else
                    {
                        if (sac.getWeight() + MainForm.listItems[i].Weight <= sac.getCapacity())
                        {
                            sac.setoneObject(i, true);
                            sac.processValue();
                            sac.processWeight();
                        }
                    }
                }
            }
        }

        // Selects candidate tour for crossover
        private static Knapsack tournamentSelection(Population pop)
        {
            Random rnd = new Random();
            // Create a tournament population
            Population tournament = new Population(tournamentSize, false);
            // For each place in the tournament get a random candidate tour and
            // add it
            for (int i = 0; i < tournamentSize; i++)
            {
                int randomId = (int)(rnd.NextDouble() * pop.populationSize());
                tournament.saveSac(i, pop.getSac(randomId));
            }
            // Get the fittest tour
            Knapsack fittest = tournament.getFittest();
            return fittest;
        }
    }
}
