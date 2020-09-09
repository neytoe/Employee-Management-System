using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CompanyUI
{   //This handles the functions on the Queries page
    public partial class QueriesUI : UserControl
    {
        public QueriesUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // EmployeedataGridView1.DataSource = Form1.EmpMethods.GetEmployee();
        }

        private void EmployeesWithDeptNameBtn(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.EmpMethods.GetAllEmployeesWithDeptName();
        }

        private void EmployeesWithSalAbove150k(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.EmpMethods.GetAllEmployeesWithSalaryAbove150k();
        }

        private void AllDeptsNotAssignedAnyEmployeeBTN(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.EmpMethods.GetAllDeptsNotAssignedEmployee();
        }

        private void AllRecordsGroupedByDeptsBTN(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.EmpMethods.GetAllEmpAndDeptGroupedByDept();
        }

        private void EmployeesAssignedAndNotAssignedBtnClick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Form1.EmpMethods.GetAllEmpAndDeptwithAssignedAndNotAssigned();
        }
    }
}
