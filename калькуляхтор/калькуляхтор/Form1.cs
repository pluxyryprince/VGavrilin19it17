using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькуляхтор
{
    public partial class Form1 : Form
    {
        public int a;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "+";
            a = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (a == 1)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (a == 2)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) - Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (a == 3)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) * Convert.ToInt32(textBox2.Text)).ToString();
            }
            if (a == 4)
            {
                label1.Text = (Convert.ToInt32(textBox1.Text) / Convert.ToInt32(textBox2.Text)).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "-";
            a = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "*";
            a = 3;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "/";
            a = 4;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label1.Text = "0";
            label2.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
