using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTxtBox_Click(object sender, EventArgs e)
        {
           
            TextBox textBox1 = new TextBox();
            TextBox textBox2 = new TextBox();
            TextBox textBox3 = new TextBox();
            TextBox textBox4 = new TextBox();
            TextBox textBox5 = new TextBox();

            Random rnd = new Random();
            int sayi,min=0,max=0;
            double avg=0.0;
            int []dizi = new int[5];
            TextBox[] array = { textBox1,textBox2,textBox3,textBox4,textBox5};
            
            for (int i = 0; i < 5; i++) {
               
                sayi = rnd.Next(1, 10);
                array[i].Text = sayi.ToString();
                array[i].Name = "txtBox" + i.ToString();
                array[i].Location = new Point(50, 80 + (i * 30));
                this.Controls.Add(array[i]);
                dizi[i] = Convert.ToInt32(array[i].Text);

                if (i == 0)
                {
                    min = dizi[i];
                    max= dizi[i];
                }

                if (min > dizi[i]) {
                    min = dizi[i];
                }

                if (max  < dizi[i])
                {
                    max = dizi[i];
                }
                avg += dizi[i];
            }
            avg = avg / 5;
            lbSonuclar.Text = "Min : " + min.ToString() + "\nMax : " + max.ToString() + "\nAvg : " + avg.ToString();
        }
    }
}
