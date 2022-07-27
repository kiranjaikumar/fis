using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationPractice
{
    public partial class AssignmentNo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Select_Chnage(object sender, EventArgs e)
        {
            
        }
        protected void CheckBtn_Click(object sender, EventArgs e)
        {
            string productId = DropDownList1.Text;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string productId = DropDownList1.Text;
            
            Label1.Text = "Change";

            if (productId == "s22")
            {
                Label1.Text = "Product Name: Samsung S22 Ultra, Product Price: 114000";
                productimg.ImageUrl = "https://www.sammobile.com/wp-content/uploads/2021/01/Galaxy-S21-Ultra-review-31.jpg";
            }
            if (productId == "N1")
            {
                Label1.Text = "Product Name: Nothing 1, Product Price: 36000";
                productimg.ImageUrl = "https://www.gofindbiz.com/wp-content/uploads/2022/07/noting-smartphone-1.jpeg";
            }
            if (productId == "13 Pro")
            {
                Label1.Text = "Product Name: Iphone 13 Pro, Product Price: 114000";
                productimg.ImageUrl = "https://mk0appletrackvxmbhbl.kinstacdn.com/wp-content/uploads/2021/05/iphone-13-pro-max-unbox-therapy-scaled.jpg";
                //productimg.ImageUrl = "C:/Users/Administrator/Downloads/iphone.jpeg";
            }
        }
    }
}