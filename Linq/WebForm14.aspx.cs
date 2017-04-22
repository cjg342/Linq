using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            List<Student14> listStudents = new List<Student14>
            {
                new Student14 { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student14 { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student14 { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };

            // LINQ Query is only defined here and is not executed at this point
            // If the query is executed at this point, the result should not display Tim
            IEnumerable<Student14> result = from student in listStudents
                                          where student.TotalMarks == 800
                                          select student;

            // Add a new student object with TotalMarks = 800 to the source
            listStudents.Add(new Student14 { StudentID = 104, Name = "Tim", TotalMarks = 800 });

            // The above query is actually executed when we iterate thru the sequence
            // using the foreach loop. This is proved as Tim is also included in the result
            foreach (Student14 s in result)
            {
                Response.Write(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks+"<br>");
            }


            Response.Write("<br>"+ "LINQ Immediate Execution" + "<br>");
            // Since we are using ToList() which is a greedy operator
            // the LINQ Query is executed immediately at this point
            IEnumerable <Student14> result2 = (from student in listStudents
                                           where student.TotalMarks == 800
                                           select student).ToList();

            // Adding a new student object with TotalMarks = 800 to the source
            // will have no effect on the result as the query is already executed
            listStudents.Add(new Student14 { StudentID = 105, Name = "Timbo", TotalMarks = 800 });

            // The above query is executed at the point where it is defined.
            // This is proved as Tim is not included in the result
            foreach (Student14 s in result2)
            {
                Response.Write(s.StudentID + "\t" + s.Name + "\t" + s.TotalMarks + "<br>");
            }












        }
    }


    public class Student14
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }


}