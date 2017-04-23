using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm26 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string[] countries = { "USA", "usa", "INDIA", "UK", "UK" };

            var result = countries.Distinct();

            foreach (var v in result)
            {
                Response.Write(v+"<br>");
            }


        }
    }
}