using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }
        private void btnAc_Click(object sender, EventArgs e)
        {
            int a, b;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            textBox3.Text = GCD(a, b).ToString();
            textBox4.Text = LCM(a, b).ToString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
