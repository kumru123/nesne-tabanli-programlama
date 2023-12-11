using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dizi1
{
    public partial class Form1 : Form
    {
        int i,flag,syc,ek,eb,ydk,j,sayi;
        
        int[] dizi= new int[10];
        Random rastgele = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            syc = 0;
            for (i = 0; i <= 9; i++)
            {
                if (dizi[i] == sayi)
                    syc++;
            }
            label2.Text = syc.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            for (i = 0; i <= 9; i++)
                 if (dizi[i] == sayi)
                    MessageBox.Show((i+1).ToString()+".sırada var");
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            for (i = 0; i <= 9; i++)
                if (dizi[i] == sayi)
                {
                    MessageBox.Show((i + 1).ToString() + ".sırada var");
                    break;
                }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            listBox3.Items.Clear();
            for (i = 0; i <= 8; i++)
                for (j = i + 1; j <= 9; j++)
                    if (dizi[i] < dizi[j])
                    {
                        ydk = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = ydk;
                    }
            for (i = 0; i <= 9; i++)
                listBox3.Items.Add(dizi[i]);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            eb = dizi[0];
            for (i = 0; i <= 9; i++)
                if (dizi[i] > eb)
                    eb = dizi[i];
            label4.Text = eb.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (i = 0; i <= 8; i++)
                for (j = i+1; j <= 9; j++)
                    if (dizi[i] > dizi[j])
                        {
                        ydk = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = ydk;
                        }
            for (i = 0; i <= 9; i++)
                listBox2.Items.Add(dizi[i]);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (i = 9; i >= 0; i--)
                if (dizi[i] == sayi)
                {
                    MessageBox.Show((i + 1).ToString() + ".sırada var");
                    break;
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ek = dizi[0];
            for (i = 0; i <= 9; i++)
                if (dizi[i] < ek)
                    ek = dizi[i];
            label3.Text = ek.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for(i=0;i<=9;i++)
            {
                dizi[i] = rastgele.Next(30, 51);
            }
            for (i = 0; i <= 9; i++)
            {
                listBox1.Items.Add(dizi[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi = Convert.ToInt32(textBox1.Text);
            flag = 0;
            for (i = 0; i <= 9; i++)
            {
                if (dizi[i] == sayi)
                    flag = 1;
            }
            if (flag == 1)
                label1.Text = "VARDIR";
            else
                label1.Text = "YOKTUR";

        }
    }
}
