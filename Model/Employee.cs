using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Employee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        public int? DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
