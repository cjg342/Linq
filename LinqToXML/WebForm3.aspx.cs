using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqToXML
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Dump to file
            var binPath = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8));

            string savedPath=(binPath + @"\Data.xml");

            IEnumerable<string> names = from student in XDocument
            .Load(savedPath)
            .Element("Students")
            .Elements("Student")
            where (int)student.Element("TotalMarks") > 800
            orderby (int)student.Element("TotalMarks") descending
            select student.Element("Name").Value;

            foreach (string name in names)
            {
                Response.Write(name+"<br>");
            }
        }
    }
}