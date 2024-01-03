using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem listView = new ListViewItem(textBox1.Text);
            listView1.Items.Add(listView);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.FocusedItem.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = listView1.FocusedItem.Index;
            listView1.Items.RemoveAt(i);
            textBox1.Text ="";
            webBrowser1.Navigate("www.google.com");
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = listView1.FocusedItem.Text;
            if (e.Button == MouseButtons.Left)
                webBrowser1.Navigate(listView1.FocusedItem.Text);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
