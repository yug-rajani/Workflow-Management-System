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
    class Task
    {
        SqlConnection con;
        SqlCommand cmd;

        public int Task_Id { get; set; }

        public int Project_Id { get; set; }

        public int AssignedTo_User_Id { get; set; }

        public int AssignedBy_User_Id { get; set; }

        public string Task_Definition { get; set; }

        public DateTime Task_StartDate { get; set; }

        public DateTime Task_Deadline { get; set; }

        public string Task_Status { get; set; }

        public Task()
        {
            con = new SqlConnection("Data Source=LAPTOP-UK43CTN;Initial Catalog=WorkFlowDB;Integrated Security=True");
        }

        public void addTask()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string s = "INSERT INTO Task VALUES(@Project_Id, @AssignedTo_User_Id, @AssignedBy_User_Id, @Task_Definition, @Task_StartDate, @Task_Deadline, @Task_Status)";

                cmd = new SqlCommand(s, con);

                cmd.Parameters.AddWithValue("@Project_Id", Project_Id);
                cmd.Parameters.AddWithValue("@AssignedTo_User_Id", AssignedTo_User_Id);
                cmd.Parameters.AddWithValue("@AssignedBy_User_Id", AssignedBy_User_Id);
                cmd.Parameters.AddWithValue("@Task_Definition", Task_Definition);
                cmd.Parameters.AddWithValue("@Task_StartDate", Task_StartDate);
                cmd.Parameters.AddWithValue("@Task_Deadline", Task_Deadline);
                cmd.Parameters.AddWithValue("@Task_Status", Task_Status);


                cmd.ExecuteNonQuery();

                MessageBox.Show("Task Added Successfully!");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message, "Error");
            }
            finally
            {
                con.Close();
            }
        }

        public void deleteTask()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "DELETE Task WHERE Query_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", Task_Id);
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
