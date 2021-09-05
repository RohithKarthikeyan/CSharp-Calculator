using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        double firstNum = 0;
        double result = 0;
        bool addButtonFlag = false;
        bool subtractButtonFlag = false;
        bool multiplyButtonFlag = false;
        bool divideButtonFlag = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "9";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += "0";
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                firstNum = double.Parse(NumberLabel.Text);  // double.Parse() converts a string to an integer
                NumberLabel.Text = "";
                addButtonFlag = true;
            }
            else
            {
                MessageBox.Show("You must enter a number!");
            }
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                firstNum = double.Parse(NumberLabel.Text);  // double.Parse() converts a string to an integer
                NumberLabel.Text = "";
                subtractButtonFlag = true;
            }
            else
            {
                MessageBox.Show("You must enter a number!");
            }
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                firstNum = double.Parse(NumberLabel.Text);  // double.Parse() converts a string to an integer
                NumberLabel.Text = "";
                multiplyButtonFlag = true;
            }
            else
            {
                MessageBox.Show("You must enter a number!");
            }
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            if (NumberLabel.Text != "")
            {
                firstNum = double.Parse(NumberLabel.Text);  // double.Parse() converts a string to an integer
                NumberLabel.Text = "";
                divideButtonFlag = true;
            }
            else
            {
                MessageBox.Show("You must enter a number!");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            result = 0;
            firstNum = 0;
            NumberLabel.Text = "";
            addButtonFlag = false;
            subtractButtonFlag = false;
            divideButtonFlag = false;
            multiplyButtonFlag = false;
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {

            if (NumberLabel.Text != "")
            {
                double secondNum = double.Parse(NumberLabel.Text);
                if (addButtonFlag == true)
                {
                    result = firstNum + secondNum;
                }
                else if (subtractButtonFlag == true)
                {
                    result = firstNum - secondNum;
                }
                else if (multiplyButtonFlag == true)
                {
                    result = firstNum * secondNum;
                }
                else if (divideButtonFlag == true)
                {
                    try
                    {
                        result = firstNum / secondNum;
                    }
                    catch(System.Exception)
                    {
                        MessageBox.Show("You have tried to divide by 0 which is not possible. Please divide by a diferent number.", "RXK0947 Div by Zero");
                    }
                }
                NumberLabel.Text = result.ToString();
                addButtonFlag = false;
                subtractButtonFlag = false;
                divideButtonFlag = false;
                multiplyButtonFlag = false;
            }
        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            NumberLabel.Text += ".";
        }
    }
}
