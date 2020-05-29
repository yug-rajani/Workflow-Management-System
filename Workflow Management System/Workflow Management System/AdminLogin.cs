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
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            wf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();   
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                AdminHome ah = new AdminHome();
                ah.Show();
                this.Hide();
            }
            else
            {
                label4.Text = "Incorrect Credentials, Please Try Again!";
            }
        }

        /*        private void AdminLogin_FormClosing(object sender, FormClosingEventArgs e)
                {
                    System.Windows.Forms.Application.Exit();
                }
        */
    }
}
