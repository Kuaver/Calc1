using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcUIBase
{
    public partial class BasicCalculator : Form
    {
        string input = string.Empty;    //Storing user input
        string operand1 = string.Empty; //Storing first operand
        string operand2 = string.Empty; //Storing second operand
        char operation;                 //Char for operation
        double result = 0.0;            //Double for result

        public BasicCalculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "0";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input != String.Empty)
            {
                operand1 = input;
            }
            operation = '*';
            input = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (input != String.Empty)
            {
                operand1 = input;
            }
            operation = '+';
            input = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (input != String.Empty)
            {
                operand1 = input;
            }
            operation = '-';
            input = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (input != String.Empty)
            {
                operand1 = input;
            }
            operation = '/';
            input = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.result = 0.0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "1";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "2";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "3";
            this.textBox1.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "4";
            this.textBox1.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "5";
            this.textBox1.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "6";
            this.textBox1.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "7";
            this.textBox1.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "8";
            this.textBox1.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += "9";
            this.textBox1.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);
            double placeholder = 0.0;

            if (result == placeholder)
            {
                if (operation == '+')
                {
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    textBox2.Text = num1.ToString();
                    textBox3.Text = num2.ToString();
                    textBox4.Text = operation.ToString();
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                    textBox2.Text = num1.ToString();
                    textBox3.Text = num2.ToString();
                    textBox4.Text = operation.ToString();
                }
                else if (operation == '*')
                {
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                    textBox2.Text = num1.ToString();
                    textBox3.Text = num2.ToString();
                    textBox4.Text = operation.ToString();
                }
                else if (operation == '/')
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        textBox1.Text = result.ToString();
                        textBox2.Text = num1.ToString();
                        textBox3.Text = num2.ToString();
                        textBox4.Text = operation.ToString();
                    }
                    else
                    {
                        textBox1.Text = "You cannot divide by zero!";
                    }

                }
            }
            else if (result != placeholder)
            {
                if (operation == '+')
                {
                    num1 = result;
                    result = num1 + num2;
                    textBox1.Text = result.ToString();
                    textBox2.Text = num1.ToString();
                    textBox3.Text = num2.ToString();
                    textBox4.Text = operation.ToString();
                }
                else if (operation == '-')
                {
                    num1 = result;
                    result = num1 - num2;
                    textBox1.Text = result.ToString();
                    textBox2.Text = num1.ToString();
                    textBox3.Text = num2.ToString();
                    textBox4.Text = operation.ToString();
                }
                else if (operation == '*')
                {
                    num1 = result;
                    result = num1 * num2;
                    textBox1.Text = result.ToString();
                    textBox2.Text = num1.ToString();
                    textBox3.Text = num2.ToString();
                    textBox4.Text = operation.ToString();
                }
                else if (operation == '/')
                {
                    if (num2 != 0)
                    {
                        num1 = result;
                        result = num1 / num2;
                        textBox1.Text = result.ToString();
                        textBox2.Text = num1.ToString();
                        textBox3.Text = num2.ToString();
                        textBox4.Text = operation.ToString();
                    }
                    else
                    {
                        textBox1.Text = "You cannot divide by zero!";
                    }

                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            input += ".";
            this.textBox1.Text += input;
        }

        private void BasicCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
