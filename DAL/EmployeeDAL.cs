using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using people;
namespace DAL
{
    public class EmployeeDAL
    {
        DBcon db = new DBcon();
        public DataTable SearchEmp(Employee e)
        {
            string query = "SELECT * FROM Employee WHERE id = " + e.empID;
            return db.Search(query);

        }
        public DataTable viewEmp()
        {
            string query = "SELECT * FROM Employee";
            return db.Search(query);
        }
    }
}
