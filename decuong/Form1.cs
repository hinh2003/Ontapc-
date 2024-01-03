using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace decuong
{
    public partial class Form1 : Form
    {
        double a, b, c;
        string d;
        public Form1()
        {
            InitializeComponent();
        }
        public void pro(string s)
        {
            d = s;
            a = Convert.ToDouble(txShow.Text);
            txShow.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KeyEnter(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            KeyEnter(1);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            KeyEnter(2);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            KeyEnter(3);

        }

        private void button9_Click(object sender, EventArgs e)
        {
            KeyEnter(4);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            KeyEnter(5);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            KeyEnter(6);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            KeyEnter(7);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            KeyEnter(8);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            KeyEnter(9);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            pro("+");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            pro("-");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            pro("*");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pro("/");

        }

        private void button18_Click(object sender, EventArgs e)
        {
            txShow.Clear();
            KeyEnter(0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txShow.Text = txShow.Text + ".";

        }

        private void button17_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(txShow.Text);
            switch (d)
            {
                case "/":
                    c = a / b; break;
                case "+":
                    c = a + b; break;
                case "-":
                    c = a - b; break;
                case "*":
                    c = a * b; break;
                default: c = b; break;
            }
            txShow.Text = c.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double t1 = Convert.ToDouble(txShow.Text) *-1; 
            txShow.Text =t1.ToString();
        }

        void KeyEnter(int i)
        {
            if (txShow.Text == "0")
            {
                txShow.Text = i.ToString();
            }

            else
            {
                txShow.Text += i.ToString();

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
