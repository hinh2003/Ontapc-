using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0) return false;

            }
            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(textBox1.Text, out num))
            {

                textBox2.WordWrap = false;
                textBox2.Text = ""; 
                for (int i = 2; i <= num; i++)
                {
                    if (IsPrimeNumber(i))
                    {
                        textBox2.Text += i.ToString() + " ";
                    }
                }
            }
            else
            {
                textBox2.Text = "Invalid Input";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
