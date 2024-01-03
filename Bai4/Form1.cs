using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string Word = "Trường đại học Mỏ - Địa chất – Khoa Công nghệ Thông tin";

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.ForeColor = Color.Aqua;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Italic);

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style ^ FontStyle.Underline);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Word;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
