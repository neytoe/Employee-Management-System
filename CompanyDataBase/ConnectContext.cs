using Microsoft.EntityFrameworkCore;
using Model;

namespace CompanyDataBase
{
    public class ConnectContext :DbContext
    {
        //dbset of employees  
        public  DbSet<Employee> Employees { get; set; }
        //Dbset of departments
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                //holds the database, the name of the database
                "Server = (LocalDB)\\MSSQLLocalDB; Database = CompanyDB; Trusted_Connection = True;"
                );

        }


    }
}
