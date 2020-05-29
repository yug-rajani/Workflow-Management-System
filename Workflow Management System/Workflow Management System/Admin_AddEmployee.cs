using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workflow_Management_System.Class;

namespace Workflow_Management_System
{
    public partial class Admin_AddEmployee : Form
    {
        public Admin_AddEmployee()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_ManageEmployees ame = new Admin_ManageEmployees();
            ame.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
               Employee emp = new Employee();
               
               emp.Name = textBox1.Text.ToString(); 
               emp.Joining_Date = dateTimePicker1.Value;
               emp.Contact_No = textBox3.Text.ToString();
               emp.Email = textBox4.Text.ToString();
               emp.Password = textBox5.Text.ToString();

               emp.addEmployee();

                Admin_ManageEmployees ame = new Admin_ManageEmployees();
                ame.Show();
                this.Hide();

        }
    }
}
