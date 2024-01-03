using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Validating += textBox2_Validating;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Validated(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            string input = textBox2.Text; 

            DateTime date;
            if (!DateTime.TryParseExact(input, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
            {
                errorProvider1.SetError(textBox2, "Ngày sinh không hợp lệ. Vui lòng nhập theo định dạng dd/mm/yyyy");
                textBox2.Focus();
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox2, "");
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            string input = textBox3.Text; 

            if (!double.TryParse(input, out _))
            {
                errorProvider1.SetError(textBox3, "Nhập số"); 
                textBox3.Focus(); 
                e.Cancel = true; 
            }
            else
            {
                errorProvider1.SetError(textBox3, ""); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {

                MessageBox.Show("Họ Tên: " + textBox1.Text + "\n" + "Ngày sinh: " + textBox2.Text + "\n" + "Điểm: " + textBox3.Text, "Kết Qủa");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
