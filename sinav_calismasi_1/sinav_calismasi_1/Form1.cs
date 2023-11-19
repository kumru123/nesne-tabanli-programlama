using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav_calismasi_1
{
    public partial class Form1 : Form
    {
        int Alank;
        int Cevrek;
        int Alandi;
        int Cevredi;
        int Alanda;
        int Cevreda;
        int Alanü;
        int Cevreü;
        int sonuc1;
        int sonuc2
;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Alanda = Convert.ToInt32(textBox2.Text);


            alanda.Text = ((3.14 * (Alanda*Alanda)).ToString());
            çevreda.Text = ((Alanda * 2 * 3.14) .ToString());
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alank = Convert.ToInt32(textBox1.Text);
            

            alank.Text = ((Alank * Alank).ToString());
            çevrek.Text = ((Alank * 4).ToString());


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Alandi = Convert.ToInt32(textBox4.Text);
            Cevredi = Convert.ToInt32(textBox3.Text);

            alandi.Text = ((Alandi * Cevredi).ToString());
            çevredi.Text = ((2*Alandi + 2*Cevredi).ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Alanü = Convert.ToInt32(textBox6.Text);
            Cevreü = Convert.ToInt32(textBox5.Text);

            alanü.Text = ((Alanü * Cevreü) / 2).ToString();
            çevreü.Text = ((3 * Alanü ).ToString());
        }
    }
}
