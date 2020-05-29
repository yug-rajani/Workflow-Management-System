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
    public partial class ManagerHome : Form
    {
        public ManagerHome()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_ManageProjects mmp = new Manager_ManageProjects();
            mmp.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Manager_ManageTasks mmt = new Manager_ManageTasks();
            mmt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_ResolveQueries mrq = new Manager_ResolveQueries();
            mrq.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manager_UpdateProjectStatus mups = new Manager_UpdateProjectStatus();
            mups.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Manager_AssignEmployee mae = new Manager_AssignEmployee();
            mae.Show();
            this.Hide();
        }
    }
}
