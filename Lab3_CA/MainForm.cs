using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CA
{
    public partial class MainForm : Form
    {
        public static List<Item> listItems;
        GenerateSet gs = new GenerateSet();
        public static double capacity=0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            LVIn.Items.Clear();
            LVOut.Items.Clear();
            listItems = gs.Generate();
            foreach (Item i in listItems)
            {
                LVIn.Items.Add(new ListViewItem(new string[] { i.Name, i.Weight.ToString(), i.Cost.ToString() }));
            }
        }

        private void btBF_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                BruteForceAlgorithm bf = new BruteForceAlgorithm(Convert.ToDouble(tbCapacity.Text));
                bf.MakeAllSets(listItems);
                sw.Stop();
                List<Item> solve = bf.GetBest();
                if (solve == null)
                    MessageBox.Show("Решение отсутствует. Время выполнения: "+sw.ElapsedTicks+" мс");
                else
                {
                    LVOut.Items.Clear();
                    foreach (Item i in solve)
                    {
                        LVOut.Items.Add(new ListViewItem(new string[] { i.Name, i.Weight.ToString(), i.Cost.ToString() }));
                    }
                    MessageBox.Show("Время выполнения: " + sw.ElapsedTicks + " мс");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный ввод, повторите");
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            LVIn.Items.Clear();
            LVOut.Items.Clear();
            tbCapacity.Clear();
            listItems = null;
        }

        private void btGenetic_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
                sw.Start();
                capacity = Convert.ToDouble(tbCapacity.Text);
                Population pop = new Population(50, true);
                // Evolve population for 100 generations
                pop = GeneticAlgorithm.evolvePopulation(pop);
                for (int i = 0; i < 100; i++)
                {
                    pop = GeneticAlgorithm.evolvePopulation(pop);
                }
                sw.Stop();
                bool[] solution = pop.getFittest().getObjects();
                bool flag = false;
                foreach(bool i in solution)
                {
                    if (i)
                    {
                        flag = i;
                        break;
                    }
                }
                if (!flag)
                    MessageBox.Show("Решение отсутствует. Время выполнения: " + sw.ElapsedTicks + " мс");
                else
                {
                    LVOut.Items.Clear();
                    for (int i=0; i < listItems.Count; i++)
                    {
                        if (solution[i])
                        {
                            LVOut.Items.Add(new ListViewItem(new string[] { listItems[i].Name, listItems[i].Weight.ToString(), listItems[i].Cost.ToString() }));
                        }
                    }
                    MessageBox.Show("Время выполнения: " + sw.ElapsedTicks + " мс");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Некорректный ввод, повторите");
            }
        }
    }
}
