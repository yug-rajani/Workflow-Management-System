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
    class Query
    {
        SqlConnection con;
        SqlCommand cmd;

        public int Query_Id { get; set; }

        public int Task_Id { get; set; }

        public DateTime Query_Date { get; set; }

        public string Query_Description { get; set; }

        public string Query_Resolution { get; set; }

        public int Employee_Id { get; set; }

        public Query()
        {
            con = new SqlConnection("Data Source=LAPTOP-UK43CTN;Initial Catalog=WorkFlowDB;Integrated Security=True");
        }

        public void addQuery()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                string s = "INSERT INTO Query VALUES(@Task_Id, @Query_Date, @Query_Description, @Query_Resolution, @Employee_Id)";
                
                cmd = new SqlCommand(s, con);

                cmd.Parameters.AddWithValue("@Task_Id", Task_Id);
                cmd.Parameters.AddWithValue("@Query_Date", Query_Date);
                cmd.Parameters.AddWithValue("@Query_Description", Query_Description);
                cmd.Parameters.AddWithValue("@Query_Resolution", Query_Resolution);
                cmd.Parameters.AddWithValue("@Employee_Id", Employee_Id);

                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Query Added! Project Manager will try to resolve soon!");
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

        public void deleteQuery()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string s = "DELETE Query WHERE Query_Id = @id";
                cmd = new SqlCommand(s, con);
                cmd.Parameters.AddWithValue("@id", Query_Id);
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