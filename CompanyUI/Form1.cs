using CompanyDataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyUI
{
    public partial class Form1 : Form
    {
        //ConnectContext Connect;

        //instance of the IEmployeeMethod
        public static IEmployeeMethod EmpMethods { get; set; }

        //Instance of IDepartmentMethod
        public static IDepartmentMethod DeptMethods { get; set; }

        public Form1( IDepartmentMethod deptMethods, IEmployeeMethod empMethods)
        {
            InitializeComponent();
           //Injection of the IEmployeeMethod and IDepartmentMethod into the forms constructor
            EmpMethods = empMethods;
            DeptMethods = deptMethods;

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            //hided all the other usercontrols
            employeeui1.Hide();
            queriesui1.Hide();
            departmentui1.Hide();
        }

        private void NavigateEmployeeBtn_Click(object sender, EventArgs e)
        {//shows only the employeepage
            employeeui1.Show();
            employeeui1.BringToFront();
            queriesui1.Hide();
            departmentui1.Hide();
        }

        private void NavigateDeptPage_Click(object sender, EventArgs e)
        {   //shows only the dept page
            employeeui1.Hide();
            queriesui1.Hide();
            departmentui1.Show();
            departmentui1.BringToFront();

        }

        private void NavigateQueriesBtn_Click(object sender, EventArgs e)
        {
            //shows only the queries page
            employeeui1.Hide();
            departmentui1.Hide();
            queriesui1.Show();
            departmentui1.BringToFront();

        }

        private void NavigateHomeBtn_Click(object sender, EventArgs e)
        { 
            //hides all the other pages
            employeeui1.Hide();
            queriesui1.Hide();
            departmentui1.Hide();
        }

        private void departmentui1_Load(object sender, EventArgs e)
        {

        }
    }
}
