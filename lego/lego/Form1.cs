using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width -= 4;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Width += 4;
        }
    }
}
