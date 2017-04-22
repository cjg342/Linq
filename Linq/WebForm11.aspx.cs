using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            IEnumerable<Student3> result = Student3.GetAllStudetns()
            .OrderBy(s => s.TotalMarks).ThenBy(s => s.Name).ThenBy(s => s.StudentID);

            foreach (Student3 student in result)
            {
                Response.Write(student.TotalMarks + "\t" + student.Name + "\t" + student.StudentID+"<br>");
            }


        }
    }

    public class Student3
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student3> GetAllStudetns()
        {
            List<Student3> listStudents = new List<Student3>
        {
            new Student3
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student3
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student3
            {
                StudentID= 103,
                Name = "Pam",
                TotalMarks = 800
            },
            new Student3
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
            new Student3
            {
                StudentID= 105,
                Name = "John",
                TotalMarks = 800
            },
        };

            return listStudents;
        }
    }




}