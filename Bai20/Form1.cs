using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(textBox1.Text);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Nodes.Add(textBox1.Text);
            textBox1.Text = "";
            treeView1.ExpandAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            treeView1.ExpandAll();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            treeView1.CollapseAll();
        }
    }
}
