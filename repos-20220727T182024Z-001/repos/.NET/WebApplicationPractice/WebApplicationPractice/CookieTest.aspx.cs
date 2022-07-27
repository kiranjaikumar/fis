using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPractice
{
    public partial class CookieTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RedirectBtn_Click(object sender, EventArgs e)
        {
            //Persistant cookies

            //HttpCookie hc = new HttpCookie("TestCookie");
            //hc["username"] = usernameText.Text;
            //hc["password"] = passwordText.Text;
            //Response.Cookies.Add(hc);
            //Response.Redirect("CookiesRedirected.aspx");

            //non-persistant

            //Response.Cookies["username"].Value = usernameText.Text;
            //Response.Cookies["password"].Value = passwordText.Text;
            //Response.Redirect("CookiesRedirected.aspx");

            //Query


        }
    }
}