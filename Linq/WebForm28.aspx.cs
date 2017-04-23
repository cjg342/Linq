using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm28 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<br>");
            Response.Write("Range" + "<br>");

            var evenNumbers = Enumerable.Range(1, 10).Where(x => x % 2 == 0);

            foreach (int i in evenNumbers)
            {
                Response.Write(i+"<br>");
            }

            Response.Write("<br>");
            Response.Write("Repeat" + "<br>");
            var result2 = Enumerable.Repeat("Hello", 5);

            foreach (var v in result2)
            {
                Response.Write(v + "<br>");
            }

        }
    }
}