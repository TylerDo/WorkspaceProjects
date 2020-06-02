using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //Form screen for simply calculator
    public partial class Calculator : Form
    {

        string sign;
        double val1;
        double val2;
        int trackKey = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        //Text field for the input on the calculator
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Clear all fields. Clear button
        private void cmdclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            val1 = 0;
            val2 = 0;
            sign = "";
        }

        //All buttons currently on design cmd with number is value 0,1,2,3... 
        private void cmd0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd0.Text;
        }

        private void cmd1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd1.Text;
        }

        private void cm2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd2.Text;
        }

        private void cmd3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd3.Text;
        }

        private void cmd4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd4.Text;
        }

        private void cmd5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd5.Text;
        }

        private void cmd6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd6.Text;
        }

        private void cmd7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd7.Text;
        }

        private void cm8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd8.Text;
        }

        private void cmd9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text = cmd9.Text;
        }

        private void cmdequal_Click(object sender, EventArgs e)
        {
            val2 = double.Parse(textBox1.Text);
            double total;
            
            //Addition
            if(sign == "+")
            {
                total = val1 + val2;
                textBox1.Text = total.ToString();
            }
            //Subtraction
            else if(sign == "-")
            {
                total = val1 - val2;
                textBox1.Text = total.ToString();
            }
            //Multiplication
            else if (sign == "*")
            {
                total = val1 * val2;
                textBox1.Text = total.ToString();
            }
            //Division
            else
            {
                total = val1 / val2;
                textBox1.Text = total.ToString();
            }
        }

        private void cmdmultiply_Click(object sender, EventArgs e)
        {
            sign = "*";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void cmdplus_Click(object sender, EventArgs e)
        {
            sign = "+";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void cmddivision_Click(object sender, EventArgs e)
        {
            sign = "/";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void cmdminus_Click(object sender, EventArgs e)
        {
            sign = "-";
            val1 = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }
    }
}
