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
    public partial class Admin_ProjectManagers : Form
    {
        public Admin_ProjectManagers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Admin_ProjectManagers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDBDataSet3.Manager' table. You can move, or remove it, as needed.
            this.managerTableAdapter.Fill(this.workFlowDBDataSet3.Manager);
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button6, "Logout");
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
            Admin_AddManager aam = new Admin_AddManager();
            aam.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(Manager_Id,System.String) like '{0}%' OR Name like '{0}%' OR Contact_No like '{0}%' OR Email like '{0}%'", textBox1.Text.ToString());
            dataGridView1.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                Manager p = new Manager();
                p.Manager_Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                p.deleteManager();
                Admin_ProjectManagers apm = new Admin_ProjectManagers();
                this.Hide();
                apm.Show();
            }
        }
    }
}
