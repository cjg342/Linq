using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strName = "pragime";
            string result = strName.ChangeFirstLetterCase();
            TextBox1.Text = result;
        }
    }

    //Need static class and this string
    public static class StringHelper
    {
        public static string ChangeFirstLetterCase(this string inputString)
        {
            if (inputString.Length > 0)
            {
                char[] charArray = inputString.ToCharArray();
                charArray[0] = char.IsUpper(charArray[0]) ?
                    char.ToLower(charArray[0]) : char.ToUpper(charArray[0]);
                return new string(charArray);
            }

            return inputString;
        }

    }

}