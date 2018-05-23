using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogInPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        wrongUser.Visible = true;
        Session["username"] = textBoxUser.Text;
        Response.Redirect("ProfilePage.aspx");
    }
}