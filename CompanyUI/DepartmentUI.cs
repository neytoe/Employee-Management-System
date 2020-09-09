using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using CompanyDataBase;

namespace CompanyUI
{
    public partial class DepartmentUI : UserControl 
    {
        int DeptID { get; set; }
        public DepartmentUI()
        {
            InitializeComponent();
          
        }

        private void DepartmentUI_Load(object sender, EventArgs e)
        {
            this.DeptdataGridView.DataSource = Form1.DeptMethods.GetDepts();
            
        }

        private void CreateDeptBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (deptnameTextbox.Text != "")
                {
                   Form1.DeptMethods.AddDept(deptnameTextbox.Text);
                    MessageBox.Show($"Dept added succesfully");
                   
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Department Name can not be empty");
            }
            this.DeptdataGridView.DataSource = Form1.DeptMethods.GetDepts();
        }

        private void DeptDatagrid_cellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DeptdataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    DeptdataGridView.CurrentRow.Selected = true;

                    DeptID = Convert.ToInt32(DeptdataGridView.Rows[e.RowIndex].Cells["DepartmentId"].FormattedValue.ToString());
                    deptnameTextbox.Text = DeptdataGridView.Rows[e.RowIndex].Cells["DepartmentName"].FormattedValue.ToString();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Selection of row/column");
            }

        }



        private void UpdateDeptClick(object sender, EventArgs e)
        {
            try
            {
                if (deptnameTextbox.Text != "")
                {
                    Form1.DeptMethods.UpdateDept(DeptID, deptnameTextbox.Text);
                    this.DeptdataGridView.DataSource = Form1.DeptMethods.GetDepts();
                    MessageBox.Show($"Department updated succesfully");
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Department Name can not be empty");
            }
        }
    }
}
