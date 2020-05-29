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
    public partial class Admin_AddManager : Form
    {
        public Admin_AddManager()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin_ProjectManagers apm = new Admin_ProjectManagers();
            apm.Show();
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
            Manager man = new Manager();
            
            man.Name = textBox1.Text.ToString();
            man.Joining_Date = dateTimePicker1.Value;
            man.Contact_No = textBox3.Text.ToString();
            man.Email = textBox4.Text.ToString();
            man.Password = textBox5.Text.ToString();

            man.addManager();

            Admin_ProjectManagers apm = new Admin_ProjectManagers();
            apm.Show();
            this.Hide();
            
        }
    }
}
