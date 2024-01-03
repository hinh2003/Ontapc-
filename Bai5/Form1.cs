using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            int sum = 0;

            // Kiểm tra xem textBox1.Text có thể được chuyển đổi thành số nguyên hay không
            if (int.TryParse(textBox1.Text, out n))
            {
                if (radioButton1.Checked)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        int oddNumber = 2 * i + 1;
                        sum += oddNumber;
                    }

                    textBox2.Text = sum.ToString();
                }
                else if (radioButton2.Checked)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        int square = i * i;
                        sum += square;
                    }
                    textBox2.Text = sum.ToString();

                }
                else if (radioButton3.Checked)
                {
                    double sum1 = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        sum1 += 1.0 / i;
                    }
                    textBox2.Text = sum1.ToString();

                }
                else if (radioButton4.Checked)
                {
                    double sum2 = 0.0;
                    for (int i = 1; i <= n; i++)
                    {
                        // Tính giai thừa của i sử dụng thư viện Math
                        double factorial = 1;
                        for (int j = 1; j <= i; j++)
                        {
                            factorial *= j;
                        }

                        // Thêm vào tổng
                        sum2 += 1.0 / factorial;
                    }
                    textBox2.Text = sum2.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn radio button trước khi tính toán.");
                }
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
