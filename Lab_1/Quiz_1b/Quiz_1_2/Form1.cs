using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {
            double number=0.0;

            try
            {
                
                number = Convert.ToInt32(txtNumber.Text);
                number = number * 5;
            }
            catch (Exception)
            {
                MessageBox.Show("Hatali girdi.");
            }

            lbResult.Text = number.ToString();
        }
    }
}
