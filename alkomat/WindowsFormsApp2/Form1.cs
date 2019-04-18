using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Form2 f2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double K = 0.7, promile;
            int p, w, v, m;
            p = Convert.ToInt16(this.textBox1.Text);
            w = Convert.ToInt16(this.textBox2.Text);
            v = Convert.ToInt16(this.textBox3.Text);
            m = Convert.ToInt16(this.textBox4.Text);

            if (this.radioButton1.Checked == true) {
                K = 0.6;
                    }
           promile = Oblicz(p, w,v,m,K);
            string s = this.textBox1.Text;


            
            
            
            //przez try uruchamiany tylko 1 okienko
            /* try
            {
                f2.Show();
            }
            catch
            {
                f2 = new Form2(); // wywołanie drugiego ekranu po naciśnięciu buttona
                f2.Show();
            } */

            f2 = new Form2(p,w,v,promile); // wywołanie drugiego ekranu po naciśnięciu buttona
            f2.Show();

            Random r = new Random();
            f2.BackColor = Color.FromArgb(r.Next(255), r.Next(255), r.Next(255)); // ustawia kolor : .LightBlue - gotowy kolor; .FromArgb(11,250,56); - sztywne barwy


            //MessageBox.Show(Application.ExecutablePath); // skąd startuje program


        }
        private double Oblicz(int p, int w, int v, int m, double K)
        {
            double resultX=0, A = 0;
            A = 20 * p + 10 * w + 16.6 * v;
            resultX = A / (K * m);
            return resultX;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        { try
            {


                int i = Convert.ToInt16(((TextBox)sender).Text);
            }
            catch
            {
                MessageBox.Show("Niepoprawna wartosc. Tylko cyfry", "Uwaga Blad");
                e.Cancel = true;
            }
            }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
