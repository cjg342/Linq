using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm22 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var result = Employee22.GetAllEmployees().Join(Department22.GetAllDepartments(),
                                        c => c.DepartmentID,
                                        d => d.ID, (employee, department) => new
                                        {
                                            EmployeeName = employee.Name,
                                            DepartmentName = department.Name
                                        });
            foreach (var employee in result)
            {
                Response.Write(employee.EmployeeName + "\t" + employee.DepartmentName+"<br>");
            }



        }
    }

    public class Department22
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Department22> GetAllDepartments()
        {
            return new List<Department22>()
        {
            new Department22 { ID = 1, Name = "IT"},
            new Department22 { ID = 2, Name = "HR"},
            new Department22 { ID = 3, Name = "Payroll"},
        };
        }
    }

    public class Employee22
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public static List<Employee22> GetAllEmployees()
        {
            return new List<Employee22>()
        {
            new Employee22 { ID = 1, Name = "Mark", DepartmentID = 1 },
            new Employee22 { ID = 2, Name = "Steve", DepartmentID = 2 },
            new Employee22 { ID = 3, Name = "Ben", DepartmentID = 1 },
            new Employee22 { ID = 4, Name = "Philip", DepartmentID = 1 },
            new Employee22 { ID = 5, Name = "Mary", DepartmentID = 2 },
            new Employee22 { ID = 6, Name = "Valarie", DepartmentID = 2 },
            new Employee22 { ID = 7, Name = "John", DepartmentID = 1 },
            new Employee22 { ID = 8, Name = "Pam", DepartmentID = 1 },
            new Employee22 { ID = 9, Name = "Stacey", DepartmentID = 2 },
            new Employee22 { ID = 10, Name = "Andy"}
        };
        }
    }



}