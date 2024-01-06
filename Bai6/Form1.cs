using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nd = textBox1.Text;
            if (!string.IsNullOrWhiteSpace(nd))
            {
                listBox1.Items.Add(nd);
            }
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (object Item in listBox1.Items)
            {

                if (int.TryParse(Item.ToString(), out int selectedNumber))
                {
                    sum += selectedNumber;
                }

            }
            MessageBox.Show("Tổng của các số là " + sum);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.Items[0]);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void button4_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox1.Items[i] = int.Parse(listBox1.Items[i].ToString()) + 2;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
                listBox1.Items[i] = Math.Pow(int.Parse((listBox1.Items[i].ToString())), 2);
        }
        private void Reset()
        {
            listBox1.SelectedItems.Clear();
        }
        private void SelectItemsByCriteria(bool isEven)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.TryParse(listBox1.Items[i].ToString(), out int number))
                {
                    if ((number % 2 == 0 && isEven) || (number % 2 != 0 && !isEven))
                    {
                        listBox1.SetSelected(i, true);
                    }
                }
            }
        }
        private void SelectItemsByCriteria1(bool isEven)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (int.TryParse(listBox1.Items[i].ToString(), out int number))
                {
                    if ((number % 5 == 0 && isEven) || (number % 3 != 0 && !isEven))
                    {
                        listBox1.SetSelected(i, true);
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Reset();
            SelectItemsByCriteria(true);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Reset();
            SelectItemsByCriteria(false);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Reset();
            SelectItemsByCriteria1(true);
        }
    }
}
