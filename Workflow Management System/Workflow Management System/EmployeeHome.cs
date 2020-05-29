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
    public partial class EmployeeHome : Form
    {
        public EmployeeHome()
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
            Employee_TasksDetails etd = new Employee_TasksDetails();
            etd.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee_AskQuery eaq = new Employee_AskQuery();
            eaq.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Employee_ViewQuery evq = new Employee_ViewQuery();
            evq.Show();
            this.Hide();
        }
    }
}
