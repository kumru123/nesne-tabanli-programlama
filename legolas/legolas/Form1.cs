using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace legolas
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            MessageBox.Show("hehehe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2.Start();

            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += rnd.Next(15);
            pictureBox2.Left += rnd.Next(15);
            pictureBox3.Left += rnd.Next(15);
            pictureBox4.Left += rnd.Next(15);
            pictureBox5.Left += rnd.Next(15);
            pictureBox6.Left += rnd.Next(15);
            pictureBox7.Left += rnd.Next(15);
            pictureBox8.Left += rnd.Next(15);

           

            if (pictureBox1.Left == 601)
            {
                timer2.Stop();
                MessageBox.Show("will turner kazandı");
            }
            if (pictureBox2.Left == 601)
            {
                timer2.Stop();
                MessageBox.Show("legolas kazandı");
            }
            if (pictureBox3.Left == 601)
            {
                timer2.Stop();
                MessageBox.Show("3. at kazandı");
            }
            if (pictureBox4.Left == 601)
            {
                timer2.Stop();
                MessageBox.Show("4. at kazandı");
            }
            if (pictureBox5.Left == 601)
            {
                timer2.Stop();
                MessageBox.Show("5. at kazandı");
            }
            if (pictureBox6.Left == 601)
            {
                timer2.Stop();
                MessageBox.Show("6. at kazandı");
            }
            if (pictureBox7.Left == 601)
            {
                timer2.Stop();
                MessageBox.Show("7. at kazandı");
            }
            if (pictureBox8.Left == 601)
            {
                timer2.Stop();
                MessageBox.Show("8. at, kazandı");
            }







        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Stop();
        }
    }
}
