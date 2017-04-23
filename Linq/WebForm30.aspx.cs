using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm30 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string[] countries1 = { "USA", "India", "UK" };
            string[] countries2 = { "USA", "India", "UK" };

            var result = countries1.SequenceEqual(countries2);

            Response.Write("Are Equal = " + result);


        }
    }
}