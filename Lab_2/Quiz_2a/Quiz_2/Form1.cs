using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createArray_Click(object sender, EventArgs e)
        {
            arrayTextbox.Text = "";
            double min, max = 0;
            int n;
            double sum = 0.0,ava;
            n = Convert.ToInt32(arraySize.Text);
            double[] myarray = new double[n];
            min = myarray[0];
            Random rnd = new Random();
            for(int i =0; i < n; i++)
            {
                
                myarray[i] = rnd.NextDouble();
                myarray[i] *= Math.Pow(10,2);
                myarray[i] = Math.Round(myarray[i], 3);
                if (i == 0)
                {
                    min = myarray[i];
                }
                if (myarray[i] > max)
                {
                    max = myarray[i];
                }
                if (myarray[i] < min)
                {
                    min = myarray[i];
                }
                sum += myarray[i];
                arrayTextbox.Text += myarray[i] + Environment.NewLine;

            }

            ava = Convert.ToDouble(sum / n);
            ava = Math.Round(ava, 3);
            min = Math.Round(min, 3);
            max = Math.Round(max, 3);

            minValue.Text = "Min Value : " + min.ToString();
            maxValue.Text = "Max Value : " + max.ToString();
            avaValue.Text = "Avg Value : " + ava.ToString();
            

        }
    }
}
