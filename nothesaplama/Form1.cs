using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nothesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize, final, ortalama;
            vize = Convert.ToDouble(txtVize.Text);
            final = Convert.ToDouble(txtFinal.Text);
            ortalama= vize*0.4 + final*0.6;
            lblOrt.Text=ortalama.ToString();

            if (ortalama > 50 ) {

                lblDurum.Text = "Geçtiniz";
                this.BackColor = Color.Green;



                    }
            if (ortalama < 50)
            {
                lblDurum.Text = "Kaldınız";
                this.BackColor = Color.Red;
            }
            if (final< 50) {
                lblDurum.Text = "Final Notunuz 50'nin Altında";
                this.BackColor = Color.Blue;
            
            }
        }
    }
}
