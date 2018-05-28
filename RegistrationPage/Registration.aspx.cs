using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
    //hee
    //and 
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {
        if (txtConfirmPass.Text == txtPass.Text)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RegistrationTable values (@Username, @Password, @Email, @Name)", con);
            cmd.Parameters.AddWithValue("Username", txtUsername.Text);
            cmd.Parameters.AddWithValue("Password", txtPass.Text);
            cmd.Parameters.AddWithValue("Email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Name", txtName.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Redirect("LogIn.aspx");
        }
        else
            Label6.Visible = true;
        txtUsername.Text = "";
        txtPass.Text = "";
        txtName.Text = "";
        txtConfirmPass.Text = "";
        txtEmail.Text = "";
    }

    protected void btnLogIn_Click(object sender, EventArgs e)
    {
        Response.Redirect("LogIn.aspx");
    }
}