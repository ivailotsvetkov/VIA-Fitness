using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogInPage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string uName = txtUsername.Text;
        string password = txtPass.Text;

        string queryString =
            "SELECT Username, Password from RegistrationTable "
                + "WHERE Username = @uName AND Password=@password ";
        SqlCommand command = new SqlCommand(queryString, con);
        command.Parameters.AddWithValue("@uName", uName);
        command.Parameters.AddWithValue("@password", password);
        con.Open();
        SqlDataReader reader = command.ExecuteReader();
        while (reader.Read())
        {
            if (uName == reader["Username"].ToString() & password == reader["Password"].ToString())
            {

                Response.Redirect("MainPage.aspx");
            }

        }
        labelWrongUser.Visible = true;
        reader.Close();



    }
}