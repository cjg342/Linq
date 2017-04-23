using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace LinqToXML
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Dump to file
            var binPath = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8));

            string savedPath = (binPath + @"\Data.xml");
            string csvSavedPath = (binPath + @"\Data.csv");

            StringBuilder sb = new StringBuilder();
            string delimiter = ",";

            XDocument.Load(savedPath).Descendants("Student")
                     .ToList().ForEach(element => sb.Append(
                                        element.Element("Name").Value + delimiter +
                                        element.Element("Gender").Value + delimiter +
                                        element.Element("TotalMarks").Value + "\r\n"));

            StreamWriter sw = new StreamWriter(csvSavedPath);
            sw.WriteLine(sb.ToString());
            sw.Close();




        }
    }
}