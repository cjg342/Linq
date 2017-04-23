using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm18 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            var employeeGroup = from employee in Employee18.GetAllEmployees()
                                group employee by employee.Department;

            foreach (var group in employeeGroup)
            {
                Response.Write(group.Key +" "+ group.Count()+"<br>");
            }


        }
    }


    public class Employee18
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }

        public static List<Employee18> GetAllEmployees()
        {
            return new List<Employee18>()
        {
            new Employee18 { ID = 1, Name = "Mark", Gender = "Male",
                                         Department = "IT", Salary = 45000 },
            new Employee18 { ID = 2, Name = "Steve", Gender = "Male",
                                         Department = "HR", Salary = 55000 },
            new Employee18 { ID = 3, Name = "Ben", Gender = "Male",
                                         Department = "IT", Salary = 65000 },
            new Employee18 { ID = 4, Name = "Philip", Gender = "Male",
                                         Department = "IT", Salary = 55000 },
            new Employee18 { ID = 5, Name = "Mary", Gender = "Female",
                                         Department = "HR", Salary = 48000 },
            new Employee18 { ID = 6, Name = "Valarie", Gender = "Female",
                                         Department = "HR", Salary = 70000 },
            new Employee18 { ID = 7, Name = "John", Gender = "Male",
                                         Department = "IT", Salary = 64000 },
            new Employee18 { ID = 8, Name = "Pam", Gender = "Female",
                                         Department = "IT", Salary = 54000 },
            new Employee18 { ID = 9, Name = "Stacey", Gender = "Female",
                                         Department = "HR", Salary = 84000 },
            new Employee18 { ID = 10, Name = "Andy", Gender = "Male",
                                         Department = "IT", Salary = 36000 }
        };
        }
    }



}