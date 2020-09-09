using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyDataBase
{
    public interface IDepartmentMethod
    {
        public void AddDept(string deptname);
        public List<Department> GetDepts();

        public void DeleteDept(int deptId);

        public void UpdateDept(int id, string deptname);
    }
}
