using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int a = 0;
        private int b = 0;
        private float x = 0;
        Random rd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            a = rd.Next(-10, 10);
            textBox1.Text = a.ToString();
            b = rd.Next(-10, 10);
            textBox2.Text = b.ToString();
            x = -b / (float)a;
            timer1.Interval = 1000; // Thay đổi thành 1000 để đếm mỗi giây
            progressBar1.Maximum = 30; 
            progressBar1.Step = 1; 

                    timer1.Start();
        }


        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                float kq = float.Parse(textBox3.Text);
                if (Math.Abs(kq - x) < 0.01)
                {
                    MessageBox.Show("Bạn đã làm đúng");
                }
                else
                    MessageBox.Show("Bạn đã trả lời sai");

            }
            catch (FormatException)
            {
                MessageBox.Show("Nhap Lai");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.PerformStep();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("Hết giờ làm bài");
            }
        }
    }
}
