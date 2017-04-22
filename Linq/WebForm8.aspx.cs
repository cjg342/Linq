using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Linq
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            IEnumerable<string> allSubjects = Student.GetAllStudetns().SelectMany(s => s.Subjects);
            foreach (string subject in allSubjects)
            {
                Response.Write(subject+"<br>");
            }

            Response.Write("<br> <br> Example2 <br> <br>");

            var result = from student in Student.GetAllStudetns()
                         from subject in student.Subjects
                         select new { StudnetName = student.Name, Subject = subject };

            foreach (var v in result)
            {
                Response.Write(v.StudnetName + " - " + v.Subject+"<br>");
            }


        }
    }


    public class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }

        public static List<Student> GetAllStudetns()
        {
            List<Student> listStudents = new List<Student>
        {
            new Student
            {
                Name = "Tom",
                Gender = "Male",
                Subjects = new List<string> { "ASP.NET", "C#" }
            },
            new Student
            {
                Name = "Mike",
                Gender = "Male",
                Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
            },
            new Student
            {
                Name = "Pam",
                Gender = "Female",
                Subjects = new List<string> { "WCF", "SQL Server", "C#" }
            },
            new Student
            {
                Name = "Mary",
                Gender = "Female",
                Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
            },
        };

            return listStudents;
        }
    }







}