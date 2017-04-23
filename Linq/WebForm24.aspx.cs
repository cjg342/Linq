using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm24 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            var result = Employee24.GetAllEmployees()
                                    .GroupJoin(Department24.GetAllDepartments(),
                                            c => c.DepartmentID,
                                            d => d.ID,
                                            (emp, depts) => new { emp, depts })
                                    .SelectMany(z => z.depts.DefaultIfEmpty(),
                                            (a, b) => new
                                            {
                                                EmployeeName = a.emp.Name,
                                                DepartmentName = b == null ? "No Department" : b.Name
                                            });


            foreach (var v in result)
            {
                Response.Write(v.EmployeeName + "\t" + v.DepartmentName+"<br>");
            }

        }
    }


    public class Department24
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Department24> GetAllDepartments()
        {
            return new List<Department24>()
        {
            new Department24 { ID = 1, Name = "IT"},
            new Department24 { ID = 2, Name = "HR"},
        };
        }
    }


    public class Employee24
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public static List<Employee24> GetAllEmployees()
        {
            return new List<Employee24>()
        {
            new Employee24 { ID = 1, Name = "Mark", DepartmentID = 1 },
            new Employee24 { ID = 2, Name = "Steve", DepartmentID = 2 },
            new Employee24 { ID = 3, Name = "Ben", DepartmentID = 1 },
            new Employee24 { ID = 4, Name = "Philip", DepartmentID = 1 },
            new Employee24 { ID = 5, Name = "Mary" }
        };
        }
    }


}