using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqToXML
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Dump to file
            var binPath = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8));

            string savedPath = (binPath + @"\Data.xml");

            XDocument xmlDocument = XDocument.Load(savedPath);

            XDocument result = new XDocument
                (new XElement("table", new XAttribute("border", 1),
                        new XElement("thead",
                            new XElement("tr",
                                new XElement("th", "Name"),
                                new XElement("th", "Gender"),
                                new XElement("th", "TotalMarks"))),
                        new XElement("tbody",
                            from student in xmlDocument.Descendants("Student")
                            select new XElement("tr",
                                        new XElement("td", student.Element("Name").Value),
                                        new XElement("td", student.Element("Gender").Value),
                                        new XElement("td", student.Element("TotalMarks").Value)))));

            Response.Write(result);
        }
    }
}