using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqToXML
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Dump to file
            var binPath = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8));

            string savedPath = (binPath + @"\Data.xml");

            XDocument xmlDocument = XDocument.Load(savedPath);

            xmlDocument.Element("Students").Add(
                    new XElement("Student", new XAttribute("Id", 105),
                        new XElement("Name", "Todd"),
                        new XElement("Gender", "Male"),
                        new XElement("TotalMarks", 980)
                        ));

            xmlDocument.Save(savedPath);




        }
    }
}