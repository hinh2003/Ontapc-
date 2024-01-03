using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog clDLog = new ColorDialog();
            DialogResult rs = clDLog.ShowDialog();
            if (rs == DialogResult.OK)
            {
                if (radioButton1.Checked == true)
                {
                    label1.ForeColor = clDLog.Color;
                }
                if (radioButton2.Checked == true)
                {
                    label1.BackColor = clDLog.Color;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
