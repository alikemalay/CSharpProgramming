using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int cSize = 1, dSize = 1;
        // List number if the number is more than one
        int[] dizi1 = { 3, 1, 3, 8, 4, 1 };
        int[] dizi2 = { 3, 3, 2, 6, 8 };
        bool existFlag = false;
        

        void DiziBirlestir(int[] a, int[] b)
        {
            listView2.Items.Clear();

            int[] c = new int[cSize];
            c[0] = a[0];
            for (int i = 1; i < a.Length; i++) {
                
                for (int j = 0; j < c.Length; j++) {

                    if (c[j] == a[i]) {
                        existFlag = true;
                    }
                }

                if (!existFlag)
                {
                    cSize++;
                    Array.Resize(ref c, c.Length + 1);
                    c[cSize - 1] = a[i];
                    
                }
                else {
                    existFlag = false;
                }
            }

            for (int i = 0; i < b.Length; i++)
            {

                for (int j = 0; j < c.Length; j++)
                {

                    if (c[j] == b[i])
                    {
                        existFlag = true;
                    }
                }

                if (!existFlag)
                {
                    cSize++;
                    Array.Resize(ref c, c.Length + 1);
                    c[cSize - 1] = b[i];

                }
                else
                {
                    existFlag = false;
                }
            }

            for (int k = 0; k < c.Length; k++) {
                listView2.Items.Add(c[k].ToString());
            }
            
        }


        void AyniElemanlar(int[] a, int[] b)
        {
            listView1.Items.Clear();

            int[] d = new int[dSize];


            for (int i = 0; i < a.Length-1; i++) {

                for (int j = i+1; j < a.Length; j++) {
                    if (a[i] == a[j]) {
                        if (dSize > 1)
                        {
                            Array.Resize(ref d, d.Length + 1);
                        }
                        d[dSize - 1] = a[i];
                        dSize++;
                    }
                }
            }

            for (int i = 0; i < b.Length - 1; i++)
            {

                for (int j = i + 1; j < b.Length; j++)
                {
                    if (b[i] == b[j])
                    {
                        Array.Resize(ref d, d.Length + 1);
                        d[dSize - 1] = b[i];
                        dSize++;
                    }
                }
            }

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        Array.Resize(ref d, d.Length + 1);
                        d[dSize - 1] = a[i];
                        dSize++;
                    }
                }
            }

            int[] e = new int[1];
            e[0] = d[0];

            for (int i = 1; i < d.Length; i++)
            {
                for (int j = 0; j < e.Length; j++)
                {
                    if (d[i] == e[j])
                    {
                        existFlag = true;
                    }
                }

                if (!existFlag)
                {
                    Array.Resize(ref e, e.Length + 1);
                    e[e.Length - 1] = d[i];
                }
                else {
                    existFlag = false;
                }

            }
            
            for (int k = 0; k < e.Length; k++)
            {
                listView1.Items.Add(e[k].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked) {
                AyniElemanlar(dizi1, dizi2);
            };
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) {
                DiziBirlestir(dizi1, dizi2);
            };
            
        }
    }
}
