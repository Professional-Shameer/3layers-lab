using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using people;
namespace _3layers_lab
{
   
    public partial class Form1 : Form
    {
        EmployeeBLL employee = new EmployeeBLL();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.empID = SearchBox.Text;
            employee.search(emp);
            dataGridView1.DataSource = employee.search(emp);
            // Employee emp = new Employee();
            //emp.empID = SearchBox.Text;
            //DataTable dt = employee.search(emp);
            //dataGridView1.DataSource = dt;

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            DataTable dt = employee.viewEmployee();
            dataGridView1.DataSource = dt;
        }
    }
}
