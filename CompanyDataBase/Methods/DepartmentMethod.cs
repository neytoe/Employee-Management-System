using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompanyDataBase
{
    //This class implements the blueprint methods of IDepartmentMethod
   public class DepartmentMethod:IDepartmentMethod
    {   
        //Implements creating a dept and adding it to the database
        public void AddDept(string deptname)
        {
            var dept = new Department { DepartmentName = deptname };
           
            //The ConnectContext class inherits from the dbContext class
     
            using (var context = new ConnectContext())
            {

                context.Departments.Add(dept);
                context.SaveChanges();
            }
        }

        //Implements deleting a dept from the database
        public void DeleteDept(int deptId)
        {
            var dept = new Department { DepartmentId = deptId};
            using (var context = new ConnectContext())
            {
                context.Departments.Remove(dept);
                context.SaveChanges();
            }
        }


        //This gets all depts in the database
        public List<Department> GetDepts()
        {   
            using (var context = new ConnectContext())
            {
              return  context.Departments.ToList();
            }
        }

        //This updates a current dept
        public void UpdateDept(int id, string deptname)
        {
            var dept = new Department { DepartmentId = id, DepartmentName = deptname };
            using (var context = new ConnectContext())
            {
                context.Departments.Update(dept);
                context.SaveChanges();
            }

        }

    }
}
