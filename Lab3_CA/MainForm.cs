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
        List<Item> listItems;
        GenerateSet gs = new GenerateSet();

        public MainForm()
        {
            InitializeComponent();
        }

        //Генерирует случайный набор вещей
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
                BruteForceAlgorithm bf = new BruteForceAlgorithm(Convert.ToDouble(tbCapacity.Text));
                bf.MakeAllSets(listItems);
                List<Item> solve = bf.GetBest();
                if (solve == null)
                    MessageBox.Show("Решение отсутствует");
                else
                {
                    LVOut.Items.Clear();
                    foreach (Item i in solve)
                    {
                        LVOut.Items.Add(new ListViewItem(new string[] { i.Name, i.Weight.ToString(), i.Cost.ToString() }));
                    }
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
    }
}
