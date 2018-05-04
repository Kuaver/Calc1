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

        private void button1_Click(object sender, EventArgs e)  //Zero Button
        {
            this.resultBox.Text = "";
            input += "0";
            this.resultBox.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)  //Multiplication Button
        {
            if (input != String.Empty)
            {
                operand1 = input;
            }
            operation = '*';
            input = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)  //Addition Button
        {
            if (input != String.Empty)
            {
                operand1 = input;
            }
            operation = '+';
            input = string.Empty;
        }

        private void button4_Click(object sender, EventArgs e)  //Subtraction Button
        {
            if (input != String.Empty)
            {
                operand1 = input;
            }
            operation = '-';
            input = string.Empty;
        }

        private void button5_Click(object sender, EventArgs e)  //Division Button
        {
            if (input != String.Empty)
            {
                operand1 = input;
            }
            operation = '/';
            input = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)  //Clear Button
        {
            this.resultBox.Text = "";
            this.num1Box.Text = "";
            this.num2Box.Text = "";
            this.operatorBox.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
            this.result = 0.0;
        }

        private void button7_Click(object sender, EventArgs e)  //One Button
        {
            this.resultBox.Text = "";
            input += "1";
            this.resultBox.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)  //Two Button
        {
            this.resultBox.Text = "";
            input += "2";
            this.resultBox.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)  //Three Button
        {
            this.resultBox.Text = "";
            input += "3";
            this.resultBox.Text += input;
        }

        private void button10_Click(object sender, EventArgs e)  //Four Button
        {
            this.resultBox.Text = "";
            input += "4";
            this.resultBox.Text += input;
        }

        private void button11_Click(object sender, EventArgs e)  //Five Button
        {
            this.resultBox.Text = "";
            input += "5";
            this.resultBox.Text += input;
        }

        private void button12_Click(object sender, EventArgs e)  //Six Button
        {
            this.resultBox.Text = "";
            input += "6";
            this.resultBox.Text += input;
        }

        private void button13_Click(object sender, EventArgs e)  //Seven Button
        {
            this.resultBox.Text = "";
            input += "7";
            this.resultBox.Text += input;
        }

        private void button14_Click(object sender, EventArgs e)  //Eight Button
        {
            this.resultBox.Text = "";
            input += "8";
            this.resultBox.Text += input;
        }

        private void button15_Click(object sender, EventArgs e)  //Nine Button
        {
            this.resultBox.Text = "";
            input += "9";
            this.resultBox.Text += input;
        }

        private void button16_Click(object sender, EventArgs e)  //Equals Button
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
                    resultBox.Text = result.ToString();
                    num1Box.Text = num1.ToString();
                    num2Box.Text = num2.ToString();
                    operatorBox.Text = operation.ToString();
                }
                else if (operation == '-')
                {
                    result = num1 - num2;
                    resultBox.Text = result.ToString();
                    num1Box.Text = num1.ToString();
                    num2Box.Text = num2.ToString();
                    operatorBox.Text = operation.ToString();
                }
                else if (operation == '*')
                {
                    result = num1 * num2;
                    resultBox.Text = result.ToString();
                    num1Box.Text = num1.ToString();
                    num2Box.Text = num2.ToString();
                    operatorBox.Text = operation.ToString();
                }
                else if (operation == '/')
                {
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        resultBox.Text = result.ToString();
                        num1Box.Text = num1.ToString();
                        num2Box.Text = num2.ToString();
                        operatorBox.Text = operation.ToString();
                    }
                    else
                    {
                        resultBox.Text = "You cannot divide by zero!";
                    }

                }
            }
            else if (result != placeholder)
            {
                if (operation == '+')
                {
                    num1 = result;
                    result = num1 + num2;
                    resultBox.Text = result.ToString();
                    num1Box.Text = num1.ToString();
                    num2Box.Text = num2.ToString();
                    operatorBox.Text = operation.ToString();
                }
                else if (operation == '-')
                {
                    num1 = result;
                    result = num1 - num2;
                    resultBox.Text = result.ToString();
                    num1Box.Text = num1.ToString();
                    num2Box.Text = num2.ToString();
                    operatorBox.Text = operation.ToString();
                }
                else if (operation == '*')
                {
                    num1 = result;
                    result = num1 * num2;
                    resultBox.Text = result.ToString();
                    num1Box.Text = num1.ToString();
                    num2Box.Text = num2.ToString();
                    operatorBox.Text = operation.ToString();
                }
                else if (operation == '/')
                {
                    if (num2 != 0)
                    {
                        num1 = result;
                        result = num1 / num2;
                        resultBox.Text = result.ToString();
                        num1Box.Text = num1.ToString();
                        num2Box.Text = num2.ToString();
                        operatorBox.Text = operation.ToString();
                    }
                    else
                    {
                        resultBox.Text = "You cannot divide by zero!";
                    }

                }
            }
        }

        private void button17_Click(object sender, EventArgs e) //Decimal Button
        {
            this.resultBox.Text = "";
            input += ".";
            this.resultBox.Text += input;
        }

        private void BasicCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
