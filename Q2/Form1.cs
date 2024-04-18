using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
    public partial class Q2 : Form
    {
        public Q2()
        {
            InitializeComponent();
        }

        private void btnaddition_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtFnum.Text);
            int num2 = int.Parse(txtSnum.Text);
            int answer = num1 + num2;
            lblAnswer.Text = "Answer is: " + answer.ToString();

        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtFnum.Text);
            int num2 = int.Parse(txtSnum.Text);
            int answer = num1 - num2;
            lblAnswer.Text = "Answer is: " + answer.ToString();

        }

        private void btnmultiplication_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtFnum.Text);
            int num2 = int.Parse(txtSnum.Text);
            int answer = num1 * num2;
            lblAnswer.Text = "Answer is: " + answer.ToString();

        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtFnum.Text);
            int num2 = int.Parse(txtSnum.Text);
            int answer = num1 / num2;
            lblAnswer.Text = "Answer is: " + answer.ToString();

        }
    }
}
