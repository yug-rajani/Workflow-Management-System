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

namespace Workflow_Management_System
{
    public partial class Manager_CreateProject : Form
    {
        public Manager_CreateProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=LAPTOP-UK43CTN;Initial Catalog=WorkFlowDB;Integrated Security=True");
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd;
                string s = "INSERT INTO Project VALUES (@Status, @Start_Date, @Deadline, @Definition, @Manager_Id)";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@Status", comboBox1.Text.ToString());
                cmd.Parameters.AddWithValue("@Start_Date",dateTimePicker1.Value);
                cmd.Parameters.AddWithValue("@Deadline", dateTimePicker2.Value);
                cmd.Parameters.AddWithValue("@Definition", textBox2.Text.ToString());
                cmd.Parameters.AddWithValue("@Manager_Id", Int32.Parse(textBox1.Text));
                cmd.ExecuteNonQuery();

                MessageBox.Show("Project Created Successfully!");

                Manager_ManageProjects mmp = new Manager_ManageProjects();
                mmp.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message, "Error");
            }
            finally
            {
                con.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Manager_ManageProjects mmp = new Manager_ManageProjects();
            mmp.Show();
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
