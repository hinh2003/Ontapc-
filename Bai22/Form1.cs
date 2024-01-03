using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem lvi  in listView1.SelectedItems)
            {
                lvi.SubItems[0].Text=textBox5.Text;
                lvi.SubItems[1].Text=textBox6.Text;
                lvi.SubItems[2].Text=textBox7.Text;
                lvi.SubItems[3].Text=textBox8.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                ListViewItem LVItem = new ListViewItem(textBox1.Text);
                ListViewItem.ListViewSubItem LVSItemHL = new ListViewItem.ListViewSubItem(LVItem, textBox2.Text);
                ListViewItem.ListViewSubItem LVSItem1 = new ListViewItem.ListViewSubItem(LVItem, textBox3.Text);
                ListViewItem.ListViewSubItem LVSItem2 = new ListViewItem.ListViewSubItem(LVItem, textBox4.Text);

                LVItem.SubItems.Add(LVSItem1);
                LVItem.SubItems.Add(LVSItem2);
                LVItem.SubItems.Add(LVSItemHL);
                listView1.Items.Add(LVItem);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
                MessageBox.Show("Phải nhập đầy đủ thông tin nhân viên");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count > 0)
            {
                listView1.Items.RemoveAt(listView1.FocusedItem.Index);
            }
            else
                MessageBox.Show("Phải chọn nhân viên muốn ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                lvi.SubItems[0].Text = textBox1.Text;
                lvi.SubItems[1].Text = textBox3.Text;
                lvi.SubItems[2].Text = textBox2.Text;
                lvi.SubItems[3].Text = textBox4.Text;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                textBox1.Text = lvi.SubItems[0].Text;
                textBox3.Text = lvi.SubItems[1].Text;
                textBox2.Text = lvi.SubItems[3].Text;
                textBox4.Text = lvi.SubItems[2].Text;
            }

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi2 in listView2.SelectedItems)
            {
                textBox8.Text = lvi2.SubItems[0].Text;
                textBox6.Text = lvi2.SubItems[1].Text;
                textBox7.Text = lvi2.SubItems[2].Text;
                textBox5.Text = lvi2.SubItems[3].Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
            {
                ListViewItem LVItem1 = new ListViewItem(textBox8.Text);
                ListViewItem.ListViewSubItem LVSItemHL = new ListViewItem.ListViewSubItem(LVItem1, textBox6.Text);
                ListViewItem.ListViewSubItem LVSItem1 = new ListViewItem.ListViewSubItem(LVItem1, textBox7.Text);
                ListViewItem.ListViewSubItem LVSItem2 = new ListViewItem.ListViewSubItem(LVItem1, textBox5.Text);

                LVItem1.SubItems.Add(LVSItemHL);
                LVItem1.SubItems.Add(LVSItem1);
                LVItem1.SubItems.Add(LVSItem2);
                listView2.Items.Add(LVItem1);
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
            }
            else
                MessageBox.Show("Phải nhập đầy đủ thông tin giao viên");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
            {
                listView2.Items.RemoveAt(listView2.FocusedItem.Index);
            }
            else
                MessageBox.Show("Phải chọn nhân giao muốn ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
