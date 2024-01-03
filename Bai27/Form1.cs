using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int TinhTuoi(DateTime ngaySinh)
        {
            DateTime ngayHienTai = DateTime.Today;
            int tuoi = ngayHienTai.Year - ngaySinh.Year;
            if (ngaySinh > ngayHienTai.AddYears(-tuoi))
                tuoi--;
            return tuoi;
        }
        private string XacDinhNhanXung(string gioiTinh, int tuoi)
        {
            if (gioiTinh == "Nam")
            {
                return tuoi < 16 ? "Chú" : "Anh";
            }
            else
            {
                return tuoi < 16 ? "Cô" : "Chị";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hoTen = textBox1.Text;
            string ngaySinhInput = textBox2.Text;
            // Kiểm tra định dạng ngày tháng năm sinh
            DateTime ngaySinh;
            if (!DateTime.TryParseExact(ngaySinhInput, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                MessageBox.Show("Nhập ngày tháng năm sinh sai định dạng (dd/MM/yyyy). Vui lòng nhập lại!");
                textBox2.Focus(); // Di chuyển con trỏ tới TextBox Ngày sinh
                return;
            }
            // Kiểm tra xem người dùng đã chọn giới tính chưa
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính!");
                return;
            }
            string gioiTinh = radioButton1.Checked ? "Nam" : "Nữ";


            // Tính tuổi
            int tuoi = TinhTuoi(ngaySinh);

            // Xác định nhân xưng
            string nhanXung = XacDinhNhanXung(gioiTinh, tuoi);

            // Hiển thị kết quả
            MessageBox.Show($"Xin chào {nhanXung} {hoTen}, bạn đã {tuoi} tuổi.", "Ngày sinh");
        }
    }
}
