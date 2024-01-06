using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ThietLapViTriComboBox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            int chiso = listBox1.Items.Count;
            for (int i = 0; i < chiso; i++)
            {
                comboBox1.Items.Add(i.ToString());
                comboBox2.Items.Add(i.ToString());
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            ThietLapViTriComboBox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(Convert.ToInt32(comboBox1.Text), textBox2.Text);
            textBox2.Text = "";
            ThietLapViTriComboBox();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ThietLapViTriComboBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("CAn phai co loi dung");
                return;
            }
            foreach (string item in listBox1.Items)
            {
                if (textBox3.Text == item)
                {
                    MessageBox.Show("San pham co");
                    textBox3.Clear();
                    return;
                }
            }

            MessageBox.Show("Sản phẩm không có trong danh sách.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;

            if (selectedIndex != -1 && selectedIndex < listBox1.Items.Count)
            {
                listBox1.Items.RemoveAt(selectedIndex);
                ThietLapViTriComboBox();

            }
        }
    }
}
