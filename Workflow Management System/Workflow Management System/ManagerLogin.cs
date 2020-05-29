using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workflow_Management_System.Class;

namespace Workflow_Management_System
{
    public partial class ManagerLogin : Form
    {
        SqlConnection con;
        public ManagerLogin()
        {
            InitializeComponent();
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Data Source=LAPTOP-UK43CTN;Initial Catalog=WorkFlowDB;Integrated Security=True");
                string Manager_Id = textBox1.Text;
                string Password = textBox2.Text;

                CommonLoginDetails.manid = Int32.Parse(textBox1.Text);

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string qry = "SELECT * from Manager where Manager_Id='" + Manager_Id + "' and Password='" + Password + "'";

                SqlCommand cmd = new SqlCommand(qry, con);

                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.Read())
                {
                    ManagerHome mh = new ManagerHome();
                    mh.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
        /*
       private void ManagerLogin_FormClosing(object sender, FormClosingEventArgs e)
       {
           System.Windows.Forms.Application.Exit();
       }
*/
    }
}
