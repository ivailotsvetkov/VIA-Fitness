using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;



    public partial class LogIn : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistration_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registration.aspx");

        }

        protected void btnLogInMainPage_Click(object sender, EventArgs e)
        {
         con.Open();
         SqlCommand cmd = new SqlCommand("Select * FROM RegistrationTable where username = '" + textBoxUser.Text + "' AND password = '" + txtPass.Text + "'", con);
         SqlDataReader dr = cmd.ExecuteReader();
         if (dr.HasRows)
         {
             Session["username"] = textBoxUser.Text;
             Response.Redirect("ProfilePage.aspx");
         }

         else
         {
             labelWrongUser.Visible = true;
         }
        

        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        localhost.WebService myService = new localhost.WebService();
        AllUsers.Text = myService.GetUsers();
    }
}
