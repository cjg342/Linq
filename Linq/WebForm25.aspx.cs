using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm25 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var result = from c in Employee25.GetAllEmployees()
                         from d in Department25.GetAllDepartments()
                         select new { c, d };

            foreach (var v in result)
            {
                Response.Write(v.c.Name + " " + v.d.Name + "<br>");
            }
        }
    }

    public class Department25
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<Department25> GetAllDepartments()
        {
            return new List<Department25>()
        {
            new Department25 { ID = 1, Name = "IT"},
            new Department25 { ID = 2, Name = "HR"},
        };
        }
    }


    public class Employee25
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }

        public static List<Employee25> GetAllEmployees()
        {
            return new List<Employee25>()
        {
            new Employee25 { ID = 1, Name = "Mark", DepartmentID = 1 },
            new Employee25 { ID = 2, Name = "Steve", DepartmentID = 2 },
            new Employee25 { ID = 3, Name = "Ben", DepartmentID = 1 },
            new Employee25 { ID = 4, Name = "Philip", DepartmentID = 1 },
            new Employee25 { ID = 5, Name = "Mary" }
        };
        }
    }




}