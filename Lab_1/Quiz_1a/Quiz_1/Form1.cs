using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double number1, number2, result;
        int n = 4;

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            result = number1 * number2;
            result = Math.Round(result, n);
            lblResult.Text = result.ToString();
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {

            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            result = number1 / number2;
            result = Math.Round(result, n);
            lblResult.Text = result.ToString();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            
            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            result = number1 + number2;
            result = Math.Round(result, n);
            lblResult.Text = result.ToString();
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            result = number1 - number2;
            result = Math.Round(result, n);
            lblResult.Text = result.ToString();
        }
    }
}
