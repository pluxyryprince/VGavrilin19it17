using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_release_2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        public int a;
        public int b;
        public int count;
        public int x;

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void two_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void one_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void three_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void four_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            //textBox1.Text = ""; 
            // label1.Text = "";
            textBox1.Clear();
            label1.Text = "";
         
        }

        private void Umnozhenie_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            
        }

        private void Delenie_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
           
        }

        private void Ravno_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / int.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
