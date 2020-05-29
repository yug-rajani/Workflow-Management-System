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
    public partial class Manager_UpdateProjectStatus : Form
    {
        public Manager_UpdateProjectStatus()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManagerHome mh = new ManagerHome();
            mh.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = string.Format("CONVERT(Project_Id,System.String) like '{0}%' OR Project_Definition like '{0}%'", textBox1.Text.ToString());
            dataGridView1.DataSource = bs;
        }

        private void Manager_UpdateProjectStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDBDataSet10.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.workFlowDBDataSet10.Project);

        }
    }
}
