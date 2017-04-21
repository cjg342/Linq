using Linq.Models;
using System;
using System.Linq;

namespace Linq
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SampleDataContext dataContext = new SampleDataContext();
            GridView1.DataSource = from student in dataContext.Students
                                   where student.Gender == "Male"
                                   select student;
            GridView1.DataBind();

        }
    }
}