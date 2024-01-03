using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai26
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateAndDisplayResult(string operatorType)
        {
            // Lấy giá trị từ TextBox của tử và mẫu cho phân số thứ nhất
            if (int.TryParse(textBox4.Text, out int tu1) && int.TryParse(textBox3.Text, out int mau1))
            {
                // Lấy giá trị từ TextBox của tử và mẫu cho phân số thứ hai
                if (int.TryParse(textBox1.Text, out int tu2) && int.TryParse(textMau.Text, out int mau2))
                {
                    try
                    {
                        // Tạo đối tượng Phanso cho cả hai phân số
                        Phanso ps1 = new Phanso(tu1, mau1);
                        Phanso ps2 = new Phanso(tu2, mau2);

                        // Thực hiện phép toán dựa trên loại phép toán được chọn
                        Phanso result = null;

                        switch (operatorType)
                        {
                            case "+":
                                result = ps1 + ps2;
                                break;
                            case "-":
                                result = ps1 - ps2;
                                break;
                            case "*":
                                result = ps1 * ps2;
                                break;
                            case "/":
                                result = ps1 / ps2;
                                break;
                        }

                        // Rút gọn kết quả
                        result.Rutgon();

                        // Hiển thị kết quả tử số và mẫu số
                        textTu.Text = result.tu.ToString();
                        txmau.Text = result.mau.ToString();
                    }
                    catch (ArgumentException ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tử và mẫu cho phân số thứ hai là số nguyên.");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tử và mẫu cho phân số thứ nhất là số nguyên.");
            }
        }
        private void btnSum_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult("+");
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult("-");

        }

        private void btnNha_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult("*");

        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            CalculateAndDisplayResult("/");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textMau.Clear();
            textTu.Clear();
            txmau.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}
