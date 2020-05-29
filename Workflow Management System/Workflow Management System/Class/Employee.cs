using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workflow_Management_System.Class
{
    class Employee
    {
        SqlConnection con;
        SqlCommand cmd;

        public int Employee_Id { get; set; }

        public String Name { get; set; }

        public DateTime Joining_Date { get; set; }

        public String Contact_No { get; set; }

        public String Email { get; set; }

        public String Password { get; set; }

        public int Project_Id { get; set; }

        public Employee()
        {
            con = new SqlConnection("Data Source=LAPTOP-UK43CTN;Initial Catalog=WorkFlowDB;Integrated Security=True");
        }
        
        public void addEmployee()
        {
            try
            {
                
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();    
                }

                string s = "INSERT INTO Employee VALUES(@Name, @Joining_Date, @Contact_No, @Email, @Password, @Project_Id)";
                cmd = new SqlCommand(s, con);

                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Joining_Date", Joining_Date);
                cmd.Parameters.AddWithValue("@Contact_No", Contact_No);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Project_Id", 1);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Added Successfully!");
            }
            catch(Exception ex)
            {
                Console.Write(ex.Message, "Error");
            }
            finally
            {
                con.Close();
            }
        }

        public void deleteEmployee()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "DELETE Employee WHERE Employee_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", Employee_Id);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message, "Error Message");
            }
            finally
            {
                con.Close();
            }

        }
    }
}