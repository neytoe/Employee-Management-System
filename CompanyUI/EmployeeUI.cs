using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Model;

namespace CompanyUI
{
    public partial class EmployeeUI : UserControl
    {
        //set variable for ID
        int ID { get; set; }
        public EmployeeUI()
        {
            InitializeComponent();
        }

        
        private void Employee_Load(object sender, EventArgs e)
        {
            var combolist = Form1.DeptMethods.GetDepts();
            EmployeedataGridView1.DataSource = Form1.EmpMethods.GetEmployee();

            foreach (var combo in combolist)
            {
                DeptcomboBox.Items.Add(combo.DepartmentName);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CreateEmployeeBtn(object sender, EventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.EmpMethods.AddEmployee(

                firstnametbox.Text,
                lastNameTbox.Text,
                emailTbox.Text,
                phonenumTbox.Text,
                DeptdateTimePicker.Value,
                Convert.ToDecimal(salaryTbox.Text),
                DeptcomboBox.Text
                );

            EmployeedataGridView1.DataSource = Form1.EmpMethods.GetEmployee();

            firstnametbox.Clear();
            lastNameTbox.Clear();
            emailTbox.Clear();
            phonenumTbox.Clear();
            salaryTbox.Clear();
        }

        private void DeleteEmpBtn(object sender, EventArgs e)
        {
            try
            {
                Form1.EmpMethods.DeleteEmployee(ID);
                EmployeedataGridView1.DataSource = Form1.EmpMethods.GetEmployee();
                MessageBox.Show("Employee deleted Successfully");

                firstnametbox.Clear();
                lastNameTbox.Clear();
                emailTbox.Clear();
                phonenumTbox.Clear();
                salaryTbox.Clear();

            }
            catch (Exception)
            {

                MessageBox.Show("Error deleting Employee");
            }
            
        }

        private void EmployeedataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (EmployeedataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    EmployeedataGridView1.CurrentRow.Selected = true;

                    ID = Convert.ToInt32(EmployeedataGridView1.Rows[e.RowIndex].Cells["Id"].FormattedValue.ToString());
                    firstnametbox.Text = EmployeedataGridView1.Rows[e.RowIndex].Cells["FirstName"].FormattedValue.ToString();
                    lastNameTbox.Text = EmployeedataGridView1.Rows[e.RowIndex].Cells["LastName"].FormattedValue.ToString();
                    emailTbox.Text = EmployeedataGridView1.Rows[e.RowIndex].Cells["Email"].FormattedValue.ToString();
                    phonenumTbox.Text = EmployeedataGridView1.Rows[e.RowIndex].Cells["PhoneNumber"].FormattedValue.ToString();
                    DeptdateTimePicker.Value = Convert.ToDateTime(EmployeedataGridView1.Rows[e.RowIndex].Cells["HireDate"].FormattedValue.ToString());
                    salaryTbox.Text = EmployeedataGridView1.Rows[e.RowIndex].Cells["Salary"].FormattedValue.ToString();
                    DeptcomboBox.Text = EmployeedataGridView1.Rows[e.RowIndex].Cells["DepartmentName"].FormattedValue.ToString();
                    //DeptcomboBox.Text

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Selection of row/column");
            }
        }

        private void UpdateEmployeeBtnClick(object sender, EventArgs e)
        {
            try
            {
                Form1.EmpMethods.UpdateEmployee(
                ID,
                firstnametbox.Text,
                lastNameTbox.Text,
                emailTbox.Text,
                phonenumTbox.Text,
                DeptdateTimePicker.Value,
                Convert.ToDecimal(salaryTbox.Text),
                DeptcomboBox.Text

                );
                EmployeedataGridView1.DataSource = Form1.EmpMethods.GetEmployee();
                MessageBox.Show($"Employee updated succesfully");

                firstnametbox.Clear();
                lastNameTbox.Clear();
                emailTbox.Clear();
                phonenumTbox.Clear();
                salaryTbox.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show($"Error Updating Employee");
            }

           
            


        }
    }
}
