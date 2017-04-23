using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;


namespace LinqToXML
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),

                new XComment("Creating an XML Tree using LINQ to XML"),

                new XElement("Students",
                    from student in Student.GetAllStudents()
                    select new XElement("Student", new XAttribute("Id", student.Id),
                                new XElement("Name", student.Name),
                                new XElement("Gender", student.Gender),
                                new XElement("TotalMarks", student.TotalMarks))
                 )
            );

            //Dump to file
            var binPath = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8));

            xmlDocument.Save(binPath + @"\Data.xml");


        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int TotalMarks { get; set; }

        public static Student[] GetAllStudents()
        {
            Student[] students = new Student[4];

            students[0] = new Student
            {
                Id = 101,
                Name = "Mark",
                Gender = "Male",
                TotalMarks = 800
            };
            students[1] = new Student
            {
                Id = 102,
                Name = "Rosy",
                Gender = "Female",
                TotalMarks = 900
            };
            students[2] = new Student
            {
                Id = 103,
                Name = "Pam",
                Gender = "Female",
                TotalMarks = 850
            };
            students[3] = new Student
            {
                Id = 104,
                Name = "John",
                Gender = "Male",
                TotalMarks = 950
            };

            return students;
        }
    }


}