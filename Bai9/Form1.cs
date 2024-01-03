using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        private PictureBox ball;

        private int ballSpeedX = 5; // Tốc độ di chuyển theo trục X
        private int ballSpeedY = 5; // Tốc độ di chuyển theo trục Y

        public Form1()
        {
            InitializeComponent();
            InitializeBall();
            // Sử dụng Timer để cập nhật vị trí của quả bóng liên tục
            Timer timer = new Timer();
            timer.Interval = 30; // Thời gian cập nhật vị trí (30ms)
            timer.Tick += Timer_Tick;
            timer.Start();
        }
        private void InitializeBall()
        {
            ball = new PictureBox();
            ball.BackColor = Color.Red; // Màu sắc của quả bóng
            ball.Size = new Size(20, 20); // Kích thước của quả bóng
            ball.Location = new Point(50, 50); // Vị trí ban đầu của quả bóng
            this.Controls.Add(ball); // Thêm quả bóng vào Form
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Cập nhật vị trí mới của quả bóng
            ball.Left += ballSpeedX;
            ball.Top += ballSpeedY;

            // Kiểm tra va chạm với các biên của Form
            if (ball.Right >= this.ClientSize.Width || ball.Left <= 0)
            {
                ballSpeedX = -ballSpeedX; // Đảo ngược hướng di chuyển khi va chạm với biên trái/phải
            }

            if (ball.Bottom >= this.ClientSize.Height || ball.Top <= 0)
            {
                ballSpeedY = -ballSpeedY; // Đảo ngược hướng di chuyển khi va chạm với biên trên/dưới
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
