using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace legolaas
{
    public partial class Form1 : Form
    {
        int[] dizi = new int[10];
        ArrayList l = new ArrayList();
        Random rastgele = new Random();
        



        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int ek = dizi[0];
            int eb = dizi[0];



            for (int i = 0; i < dizi.Length; i++)
            {

                dizi[i] = rastgele.Next(30, 50);
            }
            for (int i = 0; i < dizi.Length; i++)
            {
                listBox1.Items.Add(dizi[i]);
                l.Add(dizi[i]);
            }


            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < ek)
                {
                    ek = dizi[i];
                    label10.Text = ek.ToString();
                }

                else if (dizi[i] > eb)
                {
                    eb = dizi[i];
                    label9.Text = eb.ToString();
                }

            }




            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            int p = Convert.ToInt32(textBox1.Text);
            if(l.Contains(p))
                {
                label7.Text = "DEĞER BULUNDU";
                listBox1.SelectedIndex=l.IndexOf(p);


                int sira = Array.IndexOf(dizi, p);
                if (sira == -1)
                {
                    label3.Text = "...";
                }
                else { label3.Text = sira +1 +". sırada"; }


            }
            else
            { label7.Text = "DEĞER BULUNAMADI"; }



            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
