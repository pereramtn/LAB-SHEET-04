using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Digit_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtInput.Text += btn.Text;

        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            txtInput.Text += " " + btn.Text + " ";

        }
        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            lblAnswer.Text = "";

        }

        private void btnEaqual_Click(object sender, EventArgs e)
        {
                try
                {
                    string input = txtInput.Text;
                    string[] inputs = input.Split(' ');

                    if (inputs.Length != 3)
                    {
                        lblAnswer.Text = "";
                        return;
                    }

                    if (!int.TryParse(inputs[0], out int num1) || !int.TryParse(inputs[2], out int num2))
                    {
                        MessageBox.Show("Invalid number format. Please enter valid integer numbers.");
                        return;
                    }

                    char operation = inputs[1][0];
                    int answer = 0;

                    switch (operation)
                    {
                        case '+':
                            answer = num1 + num2;
                            break;
                        case '-':
                            answer = num1 - num2;
                            break;
                        case 'x':
                            answer = num1 * num2;
                            break;
                        case '/':
                            answer = num1 / num2;
                            break;
                    }

                    lblAnswer.Text = "= " + answer.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
    }



