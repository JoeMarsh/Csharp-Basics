using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstTextBox = 0;
        double secondTextBox = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((int)e.KeyChar == 8) //for backspace
            //    return;
            //if (e.KeyChar == '.')
            //    return;
            //if (e.KeyChar < '0' || e.KeyChar > '9') //if the char entered is not 1-9
            //    e.Handled = true; //don't display in the textbox
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 8) //for backspace
                return;
            if (e.KeyChar == '.')
                return;
            if (e.KeyChar < '0' || e.KeyChar > '9') //if the char entered is not 1-9
                e.Handled = true; //don't display in the textbox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double result = 0;
            firstTextBox = double.Parse(textBox1.Text);
            secondTextBox = double.Parse(textBox2.Text); 
            result = firstTextBox + secondTextBox;
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double result = 0;
            firstTextBox = double.Parse(textBox1.Text);
            secondTextBox = double.Parse(textBox2.Text);
            result = firstTextBox - secondTextBox;
            textBox3.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double result = 0;
            firstTextBox = double.Parse(textBox1.Text);
            secondTextBox = double.Parse(textBox2.Text);
            result = firstTextBox * secondTextBox;
            textBox3.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double result = 0;
            firstTextBox = double.Parse(textBox1.Text);
            secondTextBox = double.Parse(textBox2.Text);
            result = firstTextBox / secondTextBox;
            textBox3.Text = result.ToString();
        }
    }
}
