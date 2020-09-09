using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Department
    {
        //This models a typical department
        [Key]
        //The department Id
        public int DepartmentId { get; set; }

        //the deptName
        public string DepartmentName { get; set; }
    }
}
