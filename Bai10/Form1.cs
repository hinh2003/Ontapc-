using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selected = listBox1.SelectedItem.ToString();
                listBox2.Items.Add(selected);
                listBox1.Items.Remove(selected);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                string item = listBox1.Items[i].ToString();
                listBox2.Items.Add(item);
            }
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedItem != null)
            {
                string selected = listBox2.SelectedItem.ToString();
                listBox2.Items.Remove(selected);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string menu = "Thực đơn đã chọn:\n";

            for (int i = 0; i < listBox2.Items.Count; i++)
            {
                menu += "- " + listBox2.Items[i].ToString() + "\n";
            }

            MessageBox.Show(menu, "Thực đơn");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
