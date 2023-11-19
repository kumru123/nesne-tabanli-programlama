using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sinav_calismasi_2
{
    public partial class Form1 : Form
    {
        int day = Convert.ToInt32(DateTime.Now.DayOfWeek);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(day)
            {
                case 1:
                    MessageBox.Show("pazartesi");
                    break;
                case 2:
                    MessageBox.Show("salı");
                    break;
                case 3:
                    MessageBox.Show("çarşamba");
                    break;
                case 4:
                    MessageBox.Show("perşembe");
                    break;
                case 5:
                    MessageBox.Show("cuma");
                    break;
                case 6:
                    MessageBox.Show("cumartesi");
                    break;
                case 0:
                    MessageBox.Show("pazar");
                    break;
            }
        }
    }
}
