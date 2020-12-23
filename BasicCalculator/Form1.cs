using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        string firstInput, secondInput;
        double result = 0.0, percentage;
        char type;

        public Form1()
        {
            InitializeComponent();
        }

        private void num0_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            if (Calculation.Text == "0")
            {
                Calculation.Text = "";
            }
            Calculation.Text += "9";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            Calculation.Text += ".";
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            type = '+';
            firstInput = Calculation.Text;
            Calculation.Text = "";
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            type = '-';
            firstInput = Calculation.Text;
            Calculation.Text = "";
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            type = '/';
            firstInput = Calculation.Text;
            Calculation.Text = "";
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            percentage = Convert.ToDouble(Calculation.Text);
            if (percentage >= 0 && percentage <= 9)
            {
                Calculation.Text = "0.0" + percentage.ToString();
            } else
            {
                Calculation.Text = "0." + percentage.ToString();
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            type = '*';
            firstInput = Calculation.Text;
            Calculation.Text = "";
        }

        private void AllClear_Click(object sender, EventArgs e)
        {
            Calculation.Text = "0";
            firstInput = "";
            secondInput = "";
            result = 0.0;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            double num1, num2;
            secondInput = Calculation.Text;
            num1 = Convert.ToDouble(firstInput);
            num2 = Convert.ToDouble(secondInput);
            if (type == '+')
            {
                result = num1 + num2;
                Calculation.Text = result.ToString();
            } else if (type == '-')
            {
                result = num1 - num2;
                Calculation.Text = result.ToString();
            } else if (type == '*')
            {
                result = num1 * num2;
                Calculation.Text = result.ToString();
            } else if (type == '/')
            {
                if (num2 == 0)
                {
                    Calculation.Text = "ERROR";
                } else
                {
                    result = num1 / num2;
                    Calculation.Text = result.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
