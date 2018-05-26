using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MainPage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void btnCreate_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into WorkOut values ( @Type, @Duration, @CalBurned)", con);
        cmd.Parameters.AddWithValue("Type", txtType.Text);
        cmd.Parameters.AddWithValue("Duration", txtDuration.Text);
        cmd.Parameters.AddWithValue("CalBurned", txtCalories.Text);

        cmd.ExecuteNonQuery();

        txtType.Text = "";
        txtDuration.Text = "";
        txtCalories.Text = "";
    }

    protected void btnRefresh_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * FROM WorkOut", con);
        SqlDataReader dr = cmd.ExecuteReader();
        grid.DataSource = dr;
        grid.DataBind();
        con.Close();
    }
}