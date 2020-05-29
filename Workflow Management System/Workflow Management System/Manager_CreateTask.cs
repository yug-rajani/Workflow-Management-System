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
    public partial class Manager_CreateTask : Form
    {
        public Manager_CreateTask()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class.Task tsk = new Class.Task();

            tsk.Project_Id = Int32.Parse(textBox1.Text);
            tsk.AssignedTo_User_Id = Int32.Parse(textBox2.Text);
            tsk.AssignedBy_User_Id = Int32.Parse(textBox3.Text);
            tsk.Task_Definition = textBox4.Text;
            tsk.Task_StartDate = dateTimePicker1.Value;
            tsk.Task_Deadline = dateTimePicker2.Value;
            tsk.Task_Status = comboBox1.Text;

            tsk.addTask();

            Manager_ManageTasks mmt = new Manager_ManageTasks();
            mmt.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_ManageTasks mmt = new Manager_ManageTasks();
            mmt.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }
    }
}
