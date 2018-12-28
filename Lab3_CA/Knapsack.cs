using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CA
{
    public class Knapsack
    {
        private double capacity;
        private bool[] objects;
        private double value;
        private double weight;

        public double getWeight()
        {
            return weight;
        }

        public void setWeight(double weight)
        {
            this.weight = weight;
        }

        public void processValue()
        {
            value = 0;
            for (int i = 0; i < MainForm.listItems.Count; i++)
            {
                if (objects[i])
                {
                    value += MainForm.listItems[i].Cost;
                }
            }
        }


        public void processWeight()
        {
            weight = 0;
            for (int i = 0; i < MainForm.listItems.Count; i++)
            {
                if (objects[i])
                {
                    weight += MainForm.listItems[i].Weight;
                }
            }
        }

        public double getCapacity()
        {
            return capacity;
        }

        public void setCapacity(double capacity)
        {
            this.capacity = capacity;
        }

        public bool getoneObject(int index)
        {
            return objects[index];
        }

        public void setoneObject(int index, bool obj)
        {
            objects[index] = obj;
            processWeight();
            processValue();
        }

        public bool[] getObjects()
        {
            return objects;
        }

        public void addObjects(int index, bool obj)
        {
            this.objects[index] = obj;
            processWeight();
            processValue();
        }

        public void setObjects(bool[] objects)
        {
            this.objects = objects;
        }

        public Knapsack()
        {
            setCapacity(MainForm.capacity);
            setValue(0);
            setWeight(0);
            objects = new bool[MainForm.listItems.Count];
            for (int i=0; i<objects.Length; i++)
            {
                objects[i] = false;
            }
        }

        public Knapsack(bool[] B)
        {
            setCapacity(MainForm.listItems.Count);
            setValue(0);
            setWeight(0);
            objects = B;
            processValue();
            processWeight();
            if (weight > capacity)
            {
                MessageBox.Show("weight>capacity");
            }
        }

        public double getValue()
        {
            return value;
        }

        public void setValue(double value)
        {
            this.value = value;
        }

        public void generateIndividual()
        {
            Random rnd = new Random();
            for (int i = 0; i < objects.Length; i++)
            {
                if (rnd.NextDouble()>0.5 && getWeight() + MainForm.listItems[i].Weight <= capacity)
                {
                    objects[i] = true;
                    setValue(getValue() + MainForm.listItems[i].Cost);
                    setWeight(getWeight() + MainForm.listItems[i].Weight);
                }
            }

        }

        public double getFitness()
        {
            return value;
        }
    }

}
