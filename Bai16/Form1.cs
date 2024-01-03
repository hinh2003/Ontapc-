using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string check = "  ";
            if(checkBox1.Checked)
            {
                check += checkBox1.Text;
            }
            if (checkBox2.Checked)
            {
                check += checkBox2.Text;
            }
            if (checkBox3.Checked)
            {
                check += checkBox3.Text;
            }
            if (checkBox4.Checked)
            {
                check += checkBox4.Text;
            }
            MessageBox.Show("Họ Tên: " +textBox1.Text + "\nLớp :" +textBox2.Text + "\nCác Môn đã chọn :"+check);
        }
    }
}
