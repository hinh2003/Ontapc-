using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0;i <imageList1.Images.Count;i++)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = imageList1.Images[i];
                pictureBox.Size = new Size(50, 50);
                pictureBox.Click += new EventHandler(Form1_Click);
                flowLayoutPanel1.Controls.Add(pictureBox);
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox pic = (PictureBox)sender;
                pictureBox1.Image = pic.Image;
            }
            catch(Exception ex) { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
