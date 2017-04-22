using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] countries = { "India", "US", "UK", "Canada", "Australia" };

            string result = countries.Aggregate((a, b) => a + "/ " + b);
                    
            TextBox1.Text=result;
        }
    }
}