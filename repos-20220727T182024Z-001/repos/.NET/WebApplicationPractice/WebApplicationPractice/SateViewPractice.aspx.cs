using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPractice
{
    public partial class SateViewPractice : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void StoreBtn_Click(object sender, EventArgs e)
        {
            ViewState["username"] = Username.Text;
            ViewState["password"] = Password.Text;
            Username.Text = "";
            Password.Text = "";
        }

        protected void LoadBtn_Click(object sender, EventArgs e)
        {
            MsgLabel.Text = "Username: " + ViewState["username"].ToString() + " Password: " + ViewState["password"].ToString();
        }
    }
}