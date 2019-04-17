using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt_siszarp
{
    public partial class Form1 : Form
    {
        public static Boolean Passport, IDCard;
        public static string To, From, StartTripDate, EndTripDate, FirstName, LastName, DocumentNumber, IssueDate, ExpireDate, WeightBaggage;

        private void button1_Click(object sender, EventArgs e)
        {
            Form formAbout = new AboutBox1();
            formAbout.Show();
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void btnBook_Click(object sender, EventArgs e)
        {
            To = txtTO.Text;
            From = txtFrom.Text;
            StartTripDate = monthCalendar1.SelectionStart.ToString("dd. MM. yyyy");
            EndTripDate = monthCalendar1.SelectionEnd.ToString("dd. MM. yyyy");
            FirstName = txtFirstName.Text;
            LastName = txtLastName.Text;
            DocumentNumber = txtDocumentNO.Text;
            IssueDate = dateTimePicker1.Value.ToString("dd. MM. yyy");
            ExpireDate = dateTimePicker2.Value.ToString("dd. MM. yyy");
            WeightBaggage = numericUpDown1.Value.ToString();
            this.Hide();
            Form2 ff2 = new Form2();
            ff2.Show();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            monthCalendar1.MaxSelectionCount = 100;
            monthCalendar1.ShowToday = true;
            numericUpDown1.Increment = 5;
            numericUpDown1.ReadOnly = true;
                 


        }

        private void rdbID_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbID.Checked)
            {
                lblDocumentNO.Text = "ID Card Number";
                lblIssueDate.Text = "ID Card Issue Date";
                lblExpireDate.Text = "ID Card Expire Date";

                IDCard = true;

            }
            else
            {
                IDCard = false;


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dateTimePicker1.Value;
            dateTimePicker2.MinDate = dt;
        }

        private void rdbPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPassport.Checked) {
                lblDocumentNO.Text = "Passport Number";
                lblIssueDate.Text = "Passport Issue Date";
                lblExpireDate.Text = "Passport Expire Date";

                Passport = true;
                    

            }
            else
            {
                Passport = false;


            }
        }
    }
}
