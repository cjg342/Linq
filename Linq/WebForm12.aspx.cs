using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string[] countries = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            IEnumerable<string> result = countries.Take(3);

            foreach (string country in result)
            {
                Response.Write(country+"<br>");
            }



            Response.Write("<br>"+ "Skips the first 3 countries and retrieves the rest of them" + "<br>");

            string[] countries2 = { "Australia", "Canada", "Germany", "US", "India", "UK", "Italy" };

            IEnumerable<string> result2 = countries2.Skip(3);

            foreach (string country in result2)
            {
                Response.Write(country + "<br>");
            }

        }
    }
}