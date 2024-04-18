using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
    public partial class Q3 : Form
    {
        public Q3()
        {
            InitializeComponent();
        }

        private void btnCalanswer_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                string[] inputs = input.Split(' ');

                if (inputs.Length != 3)
                {
                    MessageBox.Show("Invalid input format. Please enter two numbers separated by an operator (e.g., 5 + 3).");
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
                    case '*':
                        answer = num1 * num2;
                        break;
                    case '/':
                        answer = num1 / num2;
                        break;
                    default:
                        MessageBox.Show("Invalid operator.");
                        return;
                }


                lblAnswer.Text = "Answer is: " + answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}