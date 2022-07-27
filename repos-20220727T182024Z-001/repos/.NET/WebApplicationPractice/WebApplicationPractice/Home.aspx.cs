using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPractice
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(PreviousPage!=null && PreviousPage.IsCrossPagePostBack)
            {
                TextBox username = (TextBox)PreviousPage.FindControl("username");
                TextBox password = (TextBox)PreviousPage.FindControl("password");


                //Persistant cookies

                HttpCookie loginCookie = new HttpCookie("LoginCookie");
                loginCookie["username"] = username.Text;
                loginCookie["password"] = password.Text;
                Response.Cookies.Add(loginCookie);

                loginCookie.Expires = DateTime.Now.AddMinutes(2);
                

                welcomeNote.Text = "Welcome " + username.Text + " Your password is: " + password.Text;

            }
            else if(Request.Cookies["LoginCookie"]!=null){
                HttpCookie rc = Request.Cookies["LoginCookie"];
                welcomeNote.Text = "Welcome " + rc["username"] + "  " + " Your password is: " + rc["password"];
            }
            else
            {
                Response.Redirect("index.aspx");
            }

        }

        protected void logoutbtn_Click(object sender, EventArgs e)
        {

        }
    }
}