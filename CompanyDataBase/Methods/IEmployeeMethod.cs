using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CompanyDataBase
{
    public interface IEmployeeMethod
    {
        //This serves as a blueprint for the Employee Method class

        //add employee
        public void AddEmployee(string fname, string lname, string email, string phoneNum, DateTime date, decimal salary, string dept);

        //Get all employees
        public IEnumerable GetEmployee();

        //updates employees
        public void UpdateEmployee(int id,string fname, string lname, string email, string phoneNum, DateTime date, decimal salary, string dept);

        //delete employees 
        public void DeleteEmployee(int empId);

        public IEnumerable GetAllEmployeesWithDeptName();

        public IEnumerable GetAllEmployeesWithSalaryAbove150k();

        public IEnumerable GetAllDeptsNotAssignedEmployee();

        public IEnumerable GetAllEmpAndDeptGroupedByDept();

        public IEnumerable GetAllEmpAndDeptwithAssignedAndNotAssigned();
    }
}
