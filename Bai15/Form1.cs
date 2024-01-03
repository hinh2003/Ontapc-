using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            double sum = 0;

            switch (comboBox1.SelectedItem.ToString())
            {
                case "+":
                    sum = a + b;
                    break;
                case "-":
                    sum = a - b;
                    break;
                case "*":
                    sum = a * b;
                    break;
                case "/":
                    if (b != 0)
                    {
                        sum = (double)a / b;
                    }
                    else
                    {
                        MessageBox.Show("KHONG CHIA DC CHO  0!");

                    }
                    break;
            }

            textBox3.Text = sum.ToString();
        }
    }
}
