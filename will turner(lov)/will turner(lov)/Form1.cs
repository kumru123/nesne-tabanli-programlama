using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace will_turner_lov_
{
    public partial class Form1 : Form
    {
        int[] Liste = new int[10];
        Random dm = new Random();
        int eb, ek, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 10;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 10;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            
            for (int i = 0; i < 10; i++)
            {
                Liste[i] = dm.Next(30, 51);

            }

            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(Liste[i]);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            eb = Liste[0];
            for (int i = 0; i < 9; i++)
            {
                if (Liste[i] > eb)
                    eb = Liste[i];
                label2.Text = eb.ToString();
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Top -= 10;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <=8 ; i++)
            {
                for (int a=i+1; a <=9; a++)
                {
                    if (Liste[i] > Liste[a])
                    {
                        y = Liste[i];
                        Liste[i] = Liste[a];
                        Liste[a] = y;
                
                    }
                }
            }
            for (int i = 0; i <=9; i++)
            {
                listBox2.Items.Add(Liste[i]);
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ek = Liste[0];
            for (int i = 0; i < 9; i++)
            {
                if (Liste[i] < ek)
                    ek = Liste[i];
                label1.Text = ek.ToString();
            }
        }
    }
}
