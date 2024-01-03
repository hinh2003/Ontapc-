using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0'; // Hiển thị ký tự bình thường
            }
            else
            {
                textBox2.PasswordChar = '*'; // Ẩn ký tự với dấu *
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin")
            {
                if (textBox2.Text == "123456")
                {
                    MessageBox.Show("Bạn đã đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Không đăng nhập thành công");
                }

            }
            else
            {
                MessageBox.Show("Không đăng nhập thành công");
            }


        }
    }
}
