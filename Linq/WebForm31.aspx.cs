using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm31 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("<br>");
            Response.Write("All" + "<br>");
            int[] numbers = { 1, 2, 3, 4, 5 };

            var result = numbers.All(x => x < 10);

            Response.Write(result);

            Response.Write("<br>");
            Response.Write("<br>");
            Response.Write("Any" + "<br>");

            int[] numbers2 = { 1, 2, 3, 4, 5 };

            var result2 = numbers2.Any();

            Response.Write(result2);

            Response.Write("<br>");
            Response.Write("<br>");
            Response.Write("Contains" + "<br>");
            int[] numbers3 = { 1, 2, 3, 4, 5 };

            var result3= numbers3.Contains(3);

            Response.Write(result3);



        }
    }
}