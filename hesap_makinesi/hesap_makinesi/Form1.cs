using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        int x;
        int y;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            label4.Text = ((x + y).ToString());

            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            label5.Text = ((x - y).ToString());

            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            label6.Text = ((x * y).ToString());

            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            label7.Text = ((x / y).ToString());

            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);

            label8.Text = ((x % y).ToString());
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
