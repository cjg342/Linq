using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            IEnumerable<int> evenNumbers = numbers.Where(num => num % 2 == 0);

            foreach (int evenNumber in evenNumbers)
            {
                Response.Write(evenNumber + "<br>");
            }
        }
    }
}