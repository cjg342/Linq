using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //IEnumerable<Student4> students = Student4.GetAllStudetns();
            //do
            //{
            //    Console.WriteLine("Please enter Page Number - 1,2,3 or 4");
            //    int pageNumber = 0; if (int.TryParse(Console.ReadLine(), out pageNumber))
            //    {
            //        if (pageNumber >= 1 && pageNumber <= 4) {
            //            int pageSize = 3;
            //            IEnumerable<Student4> result = students.Skip((pageNumber - 1) * pageSize).Take(pageSize); Console.WriteLine();
            //            Console.WriteLine("Displaying Page " + pageNumber);

            //            foreach (Student4 student in result)
            //            {
            //                Console.WriteLine(student.StudentID + "\t" + student.Name + "\t" + student.TotalMarks);
            //            }
            //            Console.WriteLine();
            //        } else {
            //            Console.WriteLine("Page number must be an integer between 1 and 4");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Page number must be an integer between 1 and 4");
            //    }
            //} while (1 == 1);

        }
    }
    

    public class Student4
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }

        public static List<Student4> GetAllStudetns()
        {
            List<Student4> listStudents = new List<Student4>
            {
                new Student4
                {
                    StudentID= 101,Name = "Tom",TotalMarks = 800
                },
                new Student4
                {
                    StudentID= 102,Name = "Sarah",TotalMarks = 900
                },
                new Student4
                {
                    StudentID= 103,Name = "Joey",TotalMarks = 800
                },
                new Student4
                {
                    StudentID= 104,Name = "James",TotalMarks = 800
                },
                new Student4
                {
                    StudentID= 105,Name = "Bob",TotalMarks = 800
                },
                new Student4
                {
                    StudentID= 106,Name = "Donna",TotalMarks = 700
                },
                new Student4
                {
                    StudentID= 107,Name = "Mike",TotalMarks = 750
                },
                new Student4
                {
                    StudentID= 101,Name = "Suzie",TotalMarks = 850
                },
                new Student4
                {
                    StudentID= 108,Name = "Billy",TotalMarks = 950
                },
                new Student4
                {
                    StudentID= 109,Name = "Joe",TotalMarks = 750
                },
                new Student4
                {
                    StudentID= 110,Name = "Chris",TotalMarks = 860
                },
                new Student4
                {
                    StudentID= 111,Name = "Mary",TotalMarks = 800
                },
            };

            return listStudents;
        }
    }










}