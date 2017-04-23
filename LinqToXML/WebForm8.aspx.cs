using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Xml.Schema;

namespace LinqToXML
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Dump to file
            var binPath = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase.Substring(8));

            string savedPath = (binPath + @"\xsdExample.xml");
            string xsdsavedPath = (binPath + @"\Students.xsd");

            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", xsdsavedPath);

            XDocument xmlDocument = XDocument.Load(savedPath);
            bool validationErrors = false;

            xmlDocument.Validate(schema, (s, c) =>
            {
                Response.Write(c.Message);
                validationErrors = true;
            });

            if (validationErrors)
            {
                Response.Write("Validation failed");
            }
            else
            {
                Response.Write("Validation succeeded");
            }

        }
    }
}

////Save to bin folder Student.xsd
//<? xml version="1.0" encoding="utf-8"?>
//<xsd:schema xmlns:xsd="http://www.w3.org/2001/XMLSchema">
//  <xsd:element name = "Students" >
//    < xsd:complexType>
//      <xsd:sequence>
//        <xsd:element name = "Student" minOccurs="1" maxOccurs="4">
//          <xsd:complexType>
//            <xsd:sequence>
//              <xsd:element name = "Name" minOccurs="1" maxOccurs="1"/>
//              <xsd:element name = "Gender" minOccurs="1" maxOccurs="1"/>
//              <xsd:element name = "TotalMarks" minOccurs="1" maxOccurs="1"/>
//            </xsd:sequence>
//          </xsd:complexType>
//        </xsd:element>
//      </xsd:sequence>
//    </xsd:complexType>
//  </xsd:element>
//</xsd:schema>

////Save to bin folder xsdExample.xml 
//<? xml version="1.0" encoding="utf-8" standalone="yes"?>
//<Students>
//  <Student>
//    <Name>Mark</Name>
//    <Gender>Male</Gender>
//    <TotalMarks>800</TotalMarks>
//  </Student>
//  <Student>
//    <Name>Rosy</Name>
//    <Gender>Female</Gender>
//    <TotalMarks>900</TotalMarks>
//  </Student>
//  <Student>
//    <Name>Pam</Name>
//    <Gender>Female</Gender>
//    <TotalMarks>850</TotalMarks>
//  </Student>
//  <Student>
//    <Name>John</Name>
//    <Gender>Male</Gender>
//    <TotalMarks>950</TotalMarks>
//  </Student>
//</Students>