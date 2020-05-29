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
    public partial class Employee_TasksDetails : Form
    {
        public Employee_TasksDetails()
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

        private void Employee_TasksDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDBDataSet7.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.workFlowDBDataSet7.Task);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(AssignedTo_User_Id,System.String) like '{0}%'", textBox1.Text.ToString());
            dataGridView1.DataSource = bs;
        }
    }
}
