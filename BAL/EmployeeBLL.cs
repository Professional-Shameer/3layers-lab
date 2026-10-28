using DAL;
using people;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
namespace BAL
{
    public class EmployeeBLL
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();

        public DataTable search(Employee e)
        {
            return employeeDAL.SearchEmp(e);
        }
        public DataTable viewEmployee()
        {
            return employeeDAL.viewEmp();
        }
    }
}