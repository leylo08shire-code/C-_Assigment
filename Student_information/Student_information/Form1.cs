using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string student_name, department;
            int student_id, semester;
            string fullInfo;

            student_name = txtname.Text;
            student_id = int.Parse(txtstudent_id.Text);
            department = txtdepartment.Text;
            semester = int.Parse(txtsemester.Text);


            fullInfo = student_name + "," + student_id + "," + department + ", " + semester;

            lbloutput.Text = fullInfo;
                      
            txtname.Text = ""; 
            txtstudent_id.Text = ""; 
            txtdepartment.Text = ""; 
            txtsemester.Text = ""; 
            lbloutput.Text = "";
        }

    }
    
}
