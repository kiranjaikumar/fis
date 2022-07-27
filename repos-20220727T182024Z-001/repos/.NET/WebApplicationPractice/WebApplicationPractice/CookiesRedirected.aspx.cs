using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPractice
{
    public partial class CookiesRedirected : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoadFromCookie_Click(object sender, EventArgs e)
        {
            //recieve data from persistant cookie

            //HttpCookie rc = Request.Cookies["TestCookie"];
            //cookieMsg.Text = rc["username"] +"  "+rc["password"];

            cookieMsg.Text = Request.Cookies["username"].Value.ToString() + "   " + Request.Cookies["password"].Value.ToString();
        }
    }
}