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
    public partial class Admin_ManageEmployees : Form
    {
        public Admin_ManageEmployees()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminHome ah = new AdminHome();
            ah.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_AddEmployee aae = new Admin_AddEmployee();
            aae.Show();
            this.Hide();
        }

        private void Admin_ManageEmployees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDBDataSet2.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.workFlowDBDataSet2.Employee);
           /* 
            TODO: This line of code loads data into the 'workFlowDBDataSet1.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.workFlowDBDataSet1.Employee);
            TODO: This line of code loads data into the 'workFlowDBDataSet.User' table. You can move, or remove it, as needed.
            this.userTableAdapter.Fill(this.workFlowDBDataSet.User);
            */

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(Employee_Id,System.String) like '{0}%' OR Name like '{0}%' OR Contact_No like '{0}%' OR Email like '{0}%'", textBox1.Text.ToString());
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Employee p = new Employee();
                p.Employee_Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                p.deleteEmployee();
                Admin_ManageEmployees ame = new Admin_ManageEmployees();
                this.Hide();
                ame.Show();
            }
        }
    }
}
