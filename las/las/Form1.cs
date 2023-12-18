using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace las
{
    public partial class Form1 : Form
    {
        int a, b, c;
        int ork = 0;
        Random rast = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            
            a = rast.Next(-50, -25);
            b = rast.Next(0, 700);
            pictureBox2.Top = a;
            pictureBox2.Left = b;
            timer1.Enabled = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            
            pictureBox1.Left = e.X;
           
            


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
                
                pictureBox2.Top += 5;

                if ((pictureBox1.Top == pictureBox2.Bottom) && (pictureBox2.Left >= pictureBox1.Left) && (pictureBox2.Left <= pictureBox1.Right))
                {
                    ork += 10;
                    label2.Text = ork + " tane ork katledildi";
                    pictureBox2.Dispose();
                    a = rast.Next(-50, -25);
                    b = rast.Next(0, 700);
                    pictureBox2.Top = a;
                    pictureBox2.Left = b;


            }
            
        }
    }
}
