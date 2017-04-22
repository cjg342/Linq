using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            int[] numbers = { 1, 2, 3, 4, 5 };
            List<int> result = numbers.ToList();
            foreach (int i in result)
            {
                Response.Write(i + "<br>");
            }



            Response.Write("<br>" + "Convert List<string> to string array. The items in the array should be sorted in ascending order." + "<br>");

            List<string> countries = new List<string> { "US", "India", "UK", "Australia", "Canada" };

            string[] result2 = (from country in countries
                               orderby country ascending
                               select country).ToArray();

            foreach (string str in result2)
            {
                Response.Write(str+"<br>");
            }

            Response.Write("<br>" + "Convert List<Student> to a Dictionary" + "<br>");


            List<Student15> listStudents = new List<Student15>
                {
                    new Student15 { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                    new Student15 { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                    new Student15 { StudentID= 103, Name = "Pam", TotalMarks = 800 }
                };

            Dictionary<int, string> result3 = listStudents
                .ToDictionary(x => x.StudentID, x => x.Name);

            foreach (KeyValuePair<int, string> kvp in result3)
            {
                Response.Write(kvp.Key + " " + kvp.Value+"<br>");
            }

        }
    }

    public class Student15
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }


}