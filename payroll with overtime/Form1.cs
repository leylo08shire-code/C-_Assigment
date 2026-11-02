using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace payroll_with_overtime
{
    public partial class aForm1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Creating Variables
            double Hours_Worked, Payrate, GrossPay;
            double validation;

            // Prevent exception data conversion using Try Parse Method
            if (double.TryParse(txtHours.Text, out validation) &&
                double.TryParse(txtPayrate.Text, out validation))
            {
                // Assigning Variables
                Hours_Worked = double.Parse(txtHours.Text);
                Payrate = double.Parse(txtPayrate.Text);

                // Check Validation user
                if (Hours_Worked > 0 && Payrate > 0)
                {
                    // Calculate the Gross Pay
                    GrossPay = Hours_Worked * Payrate;

                    lblGrossby.Text = GrossPay.ToString("C");
                }
                else
                {
                    MessageBox.Show("Hours Worked or Payrate must be greater then 0");
                }
            }
            else
            {
                MessageBox.Show("txtHours, txtPayrate only accept double or int");
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
