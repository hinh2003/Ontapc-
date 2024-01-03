using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdatePanelBackgroundColor();
        }
        private void UpdatePanelBackgroundColor()
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            UpdatePanelBackgroundColor();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = hScrollBar2.Value.ToString();
            UpdatePanelBackgroundColor();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = hScrollBar3.Value.ToString();
            UpdatePanelBackgroundColor();
        }
    }
}
