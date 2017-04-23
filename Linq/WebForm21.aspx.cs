using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var employeesByDepartment = Department21.GetAllDepartments()
            .GroupJoin(Employee21.GetAllEmployees(),
                d => d.ID,
                f => f.DepartmentID,
                (department, employees) => new
                {
                    Department = department,
                    Employees = employees
                });

            foreach (var department in employeesByDepartment)
            {
                Response.Write(department.Department.Name+"<br>");
                foreach (var employee in department.Employees)
                {
                    Response.Write(" " + employee.Name + "<br>");
                }
                Response.Write("<br>");
            }



        }
    }

    public class Department21
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Department21> GetAllDepartments()
        {
            return new List<Department21>()
        {
            new Department21 { ID = 1, Name = "IT"},
            new Department21 { ID = 2, Name = "HR"},
            new Department21 { ID = 3, Name = "Payroll"},
        };
        }
    }

    public class Employee21
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public static List<Employee21> GetAllEmployees()
        {
            return new List<Employee21>()
        {
            new Employee21 { ID = 1, Name = "Mark", DepartmentID = 1 },
            new Employee21 { ID = 2, Name = "Steve", DepartmentID = 2 },
            new Employee21 { ID = 3, Name = "Ben", DepartmentID = 1 },
            new Employee21 { ID = 4, Name = "Philip", DepartmentID = 1 },
            new Employee21 { ID = 5, Name = "Mary", DepartmentID = 2 },
            new Employee21 { ID = 6, Name = "Valarie", DepartmentID = 2 },
            new Employee21 { ID = 7, Name = "John", DepartmentID = 1 },
            new Employee21 { ID = 8, Name = "Pam", DepartmentID = 1 },
            new Employee21 { ID = 9, Name = "Stacey", DepartmentID = 2 },
            new Employee21 { ID = 10, Name = "Andy", DepartmentID = 1}
        };
        }
    }




}