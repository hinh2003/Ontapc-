using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                ListViewItem LVItem = new ListViewItem(textBox1.Text);
                ListViewItem.ListViewSubItem LVSItem = new ListViewItem.ListViewSubItem(LVItem, textBox2.Text);
                LVItem.SubItems.Add(LVSItem);
                listView1.Items.Add(LVItem);
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                }
            }
        }
    }
}
