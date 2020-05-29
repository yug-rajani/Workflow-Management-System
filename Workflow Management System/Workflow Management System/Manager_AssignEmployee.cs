using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workflow_Management_System
{
    public partial class Manager_AssignEmployee : Form
    {
        public Manager_AssignEmployee()
        {
            InitializeComponent();
        }

        private void Manager_AssignEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDBDataSet15.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.workFlowDBDataSet15.Employee);
            /*
            // TODO: This line of code loads data into the 'workFlowDBDataSet14.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.workFlowDBDataSet14.Employee);
            // TODO: This line of code loads data into the 'workFlowDBDataSet13.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.workFlowDBDataSet13.Employee);
            // TODO: This line of code loads data into the 'workFlowDBDataSet12.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.workFlowDBDataSet12.Employee);
            */

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(Employee_Id,System.String) like '{0}%'", textBox1.Text.ToString());
            dataGridView1.DataSource = bs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerHome mh = new ManagerHome();
            mh.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }
    }
}
