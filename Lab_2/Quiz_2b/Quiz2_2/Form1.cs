using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            int n = 0;
            n = Convert.ToInt32(textBox1.Text);
            int[] myarray = new int[n];
            Random rnd = new Random();
            
            for (int i = 0; i < n; i++)
            {
                myarray[i] = rnd.Next(0, 10);
            }
            

            for(int i = 0; i < 10; i++)
            {
                textBox2.Text += i.ToString() + "\t";

                for (int j = 0; j < n; j++)
                {
                    if (myarray[j] == i)
                    {
                        textBox2.Text += "* ";
                    }
                }
                textBox2.Text += Environment.NewLine;
            }

            for (int i = 0; i < n; i++)
            {
                textBox3.Text += myarray[i].ToString()+ Environment.NewLine;
            }

        }
    }
}
