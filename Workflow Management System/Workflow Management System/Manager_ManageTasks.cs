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
    public partial class Manager_ManageTasks : Form
    {
        public Manager_ManageTasks()
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

        private void Manager_ManageTasks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'workFlowDBDataSet11.Task' table. You can move, or remove it, as needed.
            this.taskTableAdapter.Fill(this.workFlowDBDataSet11.Task);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manager_CreateTask mct = new Manager_CreateTask();
            mct.Show();
            this.Hide();
        }
    }
}
