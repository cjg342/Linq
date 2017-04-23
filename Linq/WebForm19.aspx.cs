using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var employeeGroups = Employee19.GetAllEmployees()
                                        .GroupBy(x => new { x.Department, x.Gender })
                                        .OrderBy(g => g.Key.Department).ThenBy(g => g.Key.Gender)
                                        .Select(g => new
                                        {
                                            Dept = g.Key.Department,
                                            Gender = g.Key.Gender,
                                            Employees = g.OrderBy(x => x.Name)
                                        });

            foreach (var group in employeeGroups)
            {
                Response.Write(group.Dept+","+group.Gender+","+group.Employees.Count() + "<br>");
                Response.Write("--------------------------------------------" + "<br>");
                foreach (var employee in group.Employees)
                {
                    Response.Write(employee.Name + "\t" + employee.Gender+"\t"+ employee.Department+"<br>");
                }
                Response.Write("<br>"); Response.Write("<br>");
            }


        }
    }


    public class Employee19
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }

        public static List<Employee19> GetAllEmployees()
        {
            return new List<Employee19>()
        {
            new Employee19 { ID = 1, Name = "Mark", Gender = "Male",
                                         Department = "IT" },
            new Employee19 { ID = 2, Name = "Steve", Gender = "Male",
                                         Department = "HR" },
            new Employee19 { ID = 3, Name = "Ben", Gender = "Male",
                                         Department = "IT" },
            new Employee19 { ID = 4, Name = "Philip", Gender = "Male",
                                         Department = "IT" },
            new Employee19 { ID = 5, Name = "Mary", Gender = "Female",
                                         Department = "HR" },
            new Employee19 { ID = 6, Name = "Valarie", Gender = "Female",
                                         Department = "HR" },
            new Employee19 { ID = 7, Name = "John", Gender = "Male",
                                         Department = "IT" },
            new Employee19 { ID = 8, Name = "Pam", Gender = "Female",
                                         Department = "IT" },
            new Employee19 { ID = 9, Name = "Stacey", Gender = "Female",
                                         Department = "HR" },
            new Employee19 { ID = 10, Name = "Andy", Gender = "Male",
                                         Department = "IT" },
        };
        }
    }


}