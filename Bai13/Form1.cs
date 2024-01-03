using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string word = textBox1.Text;
            listBox1.Items.Add(word);
            textBox1.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
          if(listBox1.Items.Count > 0)
            {
                listBox1.Items.Clear();
            }
            else
            {
                MessageBox.Show("Khong co gi");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
