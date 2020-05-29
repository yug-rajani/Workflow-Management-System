﻿using System;
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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeLogin el = new EmployeeLogin();
            el.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagerLogin ml = new ManagerLogin();
            ml.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminLogin al = new AdminLogin();
            al.Show();
            this.Hide();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            //this.FormClosing += new FormClosingEventHandler(WelcomeForm_FormClosing);
        }
/*
        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
*/
    }
}
