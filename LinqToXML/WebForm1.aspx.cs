using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqToXML
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            XDocument xmlDocument = new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),

            new XComment("Creating an XML Tree using LINQ to XML"),

            new XElement("Students",

            new XElement("Student", new XAttribute("Id", 101),
                new XElement("Name", "Mark"),
                new XElement("Gender", "Male"),
                new XElement("TotalMarks", 800)),

            new XElement("Student", new XAttribute("Id", 102),
                new XElement("Name", "Rosy"),
                new XElement("Gender", "Female"),
                new XElement("TotalMarks", 900)),

            new XElement("Student", new XAttribute("Id", 103),
                new XElement("Name", "Pam"),
                new XElement("Gender", "Female"),
                new XElement("TotalMarks", 850)),

            new XElement("Student", new XAttribute("Id", 104),
                new XElement("Name", "John"),
                new XElement("Gender", "Male"),
                new XElement("TotalMarks", 950))));

            var binPath = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8));

            xmlDocument.Save(binPath + @"\Data.xml");

            //Response.Write(path);

        }
    }
}