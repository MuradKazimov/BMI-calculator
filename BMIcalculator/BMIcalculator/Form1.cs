using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BMIcalculator
{
    public partial class Form1 : Form
    {
        double w;
        double h;
        double x;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            w =Double.Parse(textBox1.Text);
            h =Double.Parse(textBox2.Text)/100;

            x = w / (h * h);

            textBox3.Text = String.Format("{0:f}", x);

            if (x <= 24.9)
            {
                textBox3.BackColor = Color.PowderBlue;
            }

            else if (x <= 29.9)
            {
                textBox3.BackColor = Color.Blue;
            }

            else if (x <= 34.9)
            {
                textBox3.BackColor = Color.Yellow;
            }

            else if (x <= 39.9)
            {
                textBox3.BackColor = Color.IndianRed;
            }

            else if (x >= 40)
            {
                textBox3.BackColor = Color.Red;
            }

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "";
            textBox3.BackColor = Color.White;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
