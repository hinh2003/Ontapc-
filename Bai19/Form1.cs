using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listView1.SmallImageList = imageList1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    listView1.View = View.Details;
                    break;
                case 1:
                    listView1.View = View.LargeIcon;
                    break;
                case 2:
                    listView1.View = View.SmallIcon;
                    break;
                case 3:
                    listView1.View = View.List;
                    break;
                case 4:
                    listView1.View = View.Tile;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                ListViewItem LVItem = new ListViewItem(textBox1.Text);
                LVItem.ImageIndex = 0;
                ListViewItem.ListViewSubItem LVSItem1 = new ListViewItem.ListViewSubItem(LVItem, textBox2.Text);
                ListViewItem.ListViewSubItem LVSItem2 = new ListViewItem.ListViewSubItem(LVItem, textBox3.Text);
                LVItem.SubItems.Add(LVSItem1);
                LVItem.SubItems.Add(LVSItem2);
                listView1.Items.Add(LVItem);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }
    }
}
