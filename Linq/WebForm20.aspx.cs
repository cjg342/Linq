using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm20 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Response.Write("Returns the first element from the sequence"+"<br>");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result = numbers.First();
            Response.Write("Result = " + result);

            Response.Write("<br>");
            Response.Write("The second overloaded version is used to find the first element in a sequence based on a condition" + "<br>");
            int[] numbers2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int result2 = numbers2.First(x => x % 2 == 0);
            Response.Write("Result = " + result2);

        }
    }
}