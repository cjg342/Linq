using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // The following item causes an exception
            // list.Add("ABC");

            IEnumerable<int> result = list.Cast<int>();

            foreach (int i in result)
            {
                Response.Write(i+"<br>");
            }




        }
    }
}