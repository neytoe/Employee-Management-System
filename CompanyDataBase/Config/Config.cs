using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyDataBase.Config
{
   public class Config
    {
     //create instances of the departmentMethod class and employeemthod class
        public static IDepartmentMethod MyDeptMethods = new DepartmentMethod();
        public static IEmployeeMethod MyEmployeeMethods = new EmployeeMethods();
    }
}
