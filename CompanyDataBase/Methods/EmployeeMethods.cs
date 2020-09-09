using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CompanyDataBase;
using Microsoft.EntityFrameworkCore;

namespace Model
{
   public class EmployeeMethods: IEmployeeMethod
    {
        //create an instance of the ConnectContext class
        ConnectContext context = new ConnectContext();
        //This creates an employee and adds to the database
        public void AddEmployee(string fname, string lname,string email, string phoneNum,DateTime date, decimal salary,string dept)
        {
            var person = new Employee {
                FirstName = fname,
                LastName = lname,
                Email = email,
                PhoneNumber = phoneNum,
                Salary = salary,
                HireDate=date
            };

            var d = context.Departments.Where(x => x.DepartmentName == dept).FirstOrDefault();
            person.Department = d;

            context.Employees.Add(person);
            context.SaveChanges();
        }

        //This gets all employees in the database
        public IEnumerable GetEmployee()
        {
            return context.Employees.Include(s => s.Department).Select(e => new { e.EmployeeId, e.FirstName, e.LastName, e.Email, e.PhoneNumber, e.HireDate, e.Salary, e.Department.DepartmentId, e.Department.DepartmentName }).ToList();
        }

       
        //This deletes an employee from the database
        public void DeleteEmployee(int empid)
        {
            var emp = context.Employees.Find(empid);

            if (emp != null)
            {
                context.Employees.Remove(emp);

                context.SaveChanges();
            }
        }

        //This updates an already existing employee
        public void UpdateEmployee(int id,string fname, string lname, string email, string phoneNum, DateTime date, decimal salary, string dept)
        {
            var person = new Employee
            {   
                EmployeeId=id,
                FirstName = fname,
                LastName = lname,
                Email = email,
                PhoneNumber = phoneNum,
                Salary = salary,
                HireDate = date
            };
            
            var d = context.Departments.Where(x => x.DepartmentName == dept).FirstOrDefault();
            person.Department = d;

            context.Employees.Update(person);
            context.SaveChanges();
        }

        //This gets all employees that have a dept
        public IEnumerable GetAllEmployeesWithDeptName()
        {
            return context.Employees.Include(s => s.Department)
                                    .Select(e => new {e.FirstName, e.LastName,e.Salary,  e.Department.DepartmentName })
                                    .Where(e=> e.DepartmentName != null ).ToList();
        }

        //This retrieves all employees with salary above 150k
        public IEnumerable GetAllEmployeesWithSalaryAbove150k()
        {
            return context.Employees.Include(s => s.Department)
                                    .Select(e => new { e.FirstName, e.LastName,e.Salary, e.Department.DepartmentName })
                                     .Where(e=> e.Salary >= 150000 ).ToList();
        }

        //This retrieves all depts without employees
        public IEnumerable GetAllDeptsNotAssignedEmployee()
        {
            List<string> matchingEmployees = context.Employees
               .Where(x => x.Department.DepartmentName != null)
               .Select(x => x.Department.DepartmentName)
               .ToList();

            //var dept = ctx.Departments
            //    .Where(x => !allEmployees.Contains(x.DepartmentName))
            //    .Select(s => new { Department = s.DepartmentName })
            //    .ToList();

            return context.Departments.Where(e => !matchingEmployees.Contains(e.DepartmentName))
                                     .Select(e => new{Department = e.DepartmentName})
                                     .ToList();
        }

        
        //This retirieves all employees ordered by their department
        public IEnumerable GetAllEmpAndDeptGroupedByDept()
        {
            
            return context.Employees.OrderBy(s => s.Department.DepartmentName)
                                     .Select(e => new { e.FirstName, e.LastName, e.Department.DepartmentName }).ToList();
        }

        public IEnumerable GetAllEmpAndDeptwithAssignedAndNotAssigned()
        {
           
            return context.Employees
                .Include(s => s.Department)
                .Select(e => new { e.FirstName, e.LastName, e.Department.DepartmentName })
                .ToList();
        }
    }
}
