using Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Linq
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //LINQ query using using SQL like query expressions
            IEnumerable<Students> students = from student in Students.GetAllStudents()
                                             where student.Gender == "Male"
                                             select student;
            GridView1.DataSource = students;
            GridView1.DataBind();

            //LINQ query using Lambda Expressions.
            IEnumerable<Students> students2 = Students.GetAllStudents()
            .Where(student => student.Gender == "Male");

            GridView2.DataSource = students2;
            GridView2.DataBind();
        }
    }
}