using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workflow_Management_System.Class;

namespace Workflow_Management_System
{
    public partial class Employee_AskQuery : Form
    {
        public Employee_AskQuery()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeHome eh = new EmployeeHome();
            eh.Show();
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
            Query qry = new Query();

            qry.Task_Id = Int32.Parse(textBox1.Text);
            qry.Query_Date = dateTimePicker1.Value;
            qry.Query_Description = textBox3.Text;
            qry.Query_Resolution = textBox4.Text;
            qry.Employee_Id = Int32.Parse(textBox5.Text);

            qry.addQuery();

            EmployeeHome eh = new EmployeeHome();
            eh.Show();
            this.Hide();
        }
    }
}