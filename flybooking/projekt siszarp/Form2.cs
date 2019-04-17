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

namespace projekt_siszarp
{
    public partial class Form2 : Form
    {
        string textToFile = "";
        public Form2()
        {
            InitializeComponent();
            textToFile = (System.DateTime.Today).ToString() + "," + Form1.FirstName.ToString() + "," + Form1.LastName.ToString() + "," + Form1.From.ToString() + ","
                + Form1.To.ToString() + "," + Form1.StartTripDate.ToString() + "to" + Form1.EndTripDate.ToString() + "," +
                Form1.DocumentNumber.ToString() + "," + Form1.ExpireDate.ToString() + "," + Form1.WeightBaggage.ToString() + ","
    ;
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Form1.Passport)
            {
                lblChangeDocument.Text = "Passport Number";
                lblchangeExpire.Text = "Passport Expire Date";
            }
            if (Form1.IDCard)
            {
                lblChangeDocument.Text = "ID Card Number";
                lblchangeExpire.Text = "ID Card Expire Date";
            }


            lblFullName.Text = Form1.FirstName + "  " + Form1.LastName;
            lblDepartureCity.Text = Form1.From;
            lblDestinationCity.Text = Form1.To;
            lblTripDates.Text = Form1.StartTripDate + " to " + Form1.EndTripDate;
            lblDocumentNumber .Text = Form1.DocumentNumber;
            lblDocumentExpireDate.Text = Form1.ExpireDate;
            lblBaggageWeight.Text = Form1.WeightBaggage;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter strumien;
            bool czyIstnieje = false;
            czyIstnieje = File.Exists("Booking.csv");

            strumien = File.AppendText("Booking.csv");
            if (!czyIstnieje)
            {
                strumien.WriteLine("Data,FirstName,LastName,From,To,TripDate,DocumentNumber,ExpireDate,WeightBaggage");
            }
            strumien.WriteLine(textToFile);
            strumien.Close();
            Application.Exit();
        }
    }
}
