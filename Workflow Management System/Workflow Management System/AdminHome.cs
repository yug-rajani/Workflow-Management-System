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
    public partial class AdminHome : Form
    {
        public AdminHome()
        {
            InitializeComponent();
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button4, "Logout");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_ProjectManagers apm = new Admin_ProjectManagers();
            apm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin_ManageEmployees ame = new Admin_ManageEmployees();
            ame.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_TrackProjects atp = new Admin_TrackProjects();
            atp.Show();
            this.Hide();
        }
    }
}
