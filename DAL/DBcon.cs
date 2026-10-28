using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class DBcon
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=EmployeeDB;Integrated Security=True";
        public DataTable Search(string query)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(query, con))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
       }
    }