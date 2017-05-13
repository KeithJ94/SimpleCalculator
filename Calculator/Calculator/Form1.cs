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
        string input = string.Empty;    //String storing User Input
        string operand1 = string.Empty;  //String storing first operand 
        string operand2 = string.Empty; //String storing second operand
        char operation; //char for operation
        double result = 0.0; //calculated result

        public Form1()
        {
            InitializeComponent();
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "1";
            this.richTextBox1.Text += input;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "2";
            this.richTextBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "3";
            this.richTextBox1.Text += input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "4";
            this.richTextBox1.Text += input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "5";
            this.richTextBox1.Text += input;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "6";
            this.richTextBox1.Text += input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "7";
            this.richTextBox1.Text += input;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "8";
            this.richTextBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "9";
            this.richTextBox1.Text += input;
        }

        private void Ten_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += "0";
            this.richTextBox1.Text += input;
        }

        private void Eleven_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            input += ".";
            this.richTextBox1.Text += input;
        }

        private void Twelve_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            if(operation == '+')
            {
                result = num1 + num2;
                richTextBox1.Text = result.ToString();
            }

            else if(operation == '-')
            {
                result = num1 - num2;
                richTextBox1.Text = result.ToString();
            }

            else if(operation == '*')
            {
                result = num1 * num2;
                richTextBox1.Text = result.ToString();
            }

            else if (operation == '/')
            {
                if (num2 !=0) {
                    result = num1 / num2;
                    richTextBox1.Text = result.ToString();
                }
                else
                {
                    richTextBox1.Text = "DIV/Zero";
                }
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
