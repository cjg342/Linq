using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm27 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            int[] numbers1 = { 1, 2, 3, 4, 5 };
            int[] numbers2 = { 1, 3, 6, 7, 8 };

            var result = numbers1.Union(numbers2);

            foreach (var v in result)
            {
                Response.Write(v+"<br>");
            }

            Response.Write("<br>");
            Response.Write("Intersect"+ "<br>");
            int[] numbers3 = { 1, 2, 3, 4, 5 };
            int[] numbers4 = { 1, 3, 6, 7, 8 };

            var result2 = numbers3.Intersect(numbers4);

            foreach (var v in result2)
            {
                Response.Write(v + "<br>");
            }


            Response.Write("<br>");
            Response.Write("Except" + "<br>");
            int[] numbers5 = { 1, 2, 3, 4, 5 };
            int[] numbers6 = { 1, 3, 6, 7, 8 };

            var result3 = numbers5.Except(numbers6);

            foreach (var v in result3)
            {
                Response.Write(v + "<br>");
            }



        }
    }
}