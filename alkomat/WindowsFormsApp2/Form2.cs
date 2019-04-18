using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        int numer = 0;
        string nazwapliku = "";
        string[] komunikaty = { "Jesteś trzeźwy!", "Nie siadaj za kółkiem!","dales w czape", "w dupe pijany","Lecz sie pijaku!!!!" };
        string textToFile = "";
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int p, int w , int v, double promile)
        {
            InitializeComponent();// buduje formatkę

            if (promile <= 0.2) numer = 0;
            else if (promile <= 0.5) numer = 1;
            else if (promile <= 2.5) numer = 2;
            else if (promile <= 5) numer = 3;
            else numer = 4;
                nazwapliku = "a\\" + numer.ToString() + ".jpg" ;
            this.label1.Text = komunikaty[numer];
            this.pictureBox1.Load(nazwapliku);
            this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.label2.Text = "Piwo:" + p.ToString();
            this.label3.Text = "Wino:" + w.ToString();
            this.label4.Text = "Vodka:" + v.ToString();
            this.label5.Text = "Promile:" + (Math.Round(promile, 2)).ToString();
            this.progressBar1.Value = promile > 6 ? 6 : Convert.ToInt16(promile);
            textToFile = (System.DateTime.Today).ToString() + ";" + p.ToString() + ";" + w.ToString() + ";" + v.ToString() + ";"+
                (Math.Round(promile, 2)).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StreamWriter strumien;
            bool czyIstnieje = false;
            czyIstnieje = File.Exists("Alko-Wyniki.csv");

            strumien = File.AppendText("Alko-Wyniki.csv");
            if (!czyIstnieje)
            { strumien.WriteLine("Data;Piwo;Wino;Vodka;Promile");
            }
            strumien.WriteLine(textToFile);
            strumien.Close();
        }
    }
}
