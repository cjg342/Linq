using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            IEnumerable<Student2> result = Student2.GetAllStudents().OrderBy(s => s.Name);
            foreach (Student2 student in result)
            {
                Response.Write(student.Name+"<br>");
            }


        }
    }



    public class Student2
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student2> GetAllStudents()
        {
            List<Student2> listStudents = new List<Student2>
        {
            new Student2
            {
                StudentID= 101,
                Name = "Tom",
                TotalMarks = 800
            },
            new Student2
            {
                StudentID= 102,
                Name = "Mary",
                TotalMarks = 900
            },
            new Student2
            {
                StudentID= 103,
                Name = "Valarie",
                TotalMarks = 800
            },
            new Student2
            {
                StudentID= 104,
                Name = "John",
                TotalMarks = 800
            },
        };

            return listStudents;
        }
    }








}