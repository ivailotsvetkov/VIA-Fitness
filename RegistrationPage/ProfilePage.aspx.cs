using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ProfilePage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        usernameLabel.Text = Session["username"].ToString();
        int totalTime1 = 0;
        int totalCal1 = 0;
        con.Open();
        SqlCommand cmd = new SqlCommand("Select Type, duration, calburned FROM WorkOut where username = '" + usernameLabel.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        grid.DataSource = dr;
        grid.DataBind();
        con.Close();
        con.Open();
        SqlCommand cmd1 = new SqlCommand("Select duration, calburned FROM WorkOut where username = '" + usernameLabel.Text + "'", con);
        SqlDataReader dr1 = cmd1.ExecuteReader();
        while (dr1.Read())
        {
            totalTime1 += (int)dr1.GetValue(0);
            totalCal1 += (int)dr1.GetValue(1);
        }
        con.Close();

        totalCal.Text = " " + totalCal1;
        totalTime.Text = " " + totalTime1;
    }


    protected void grid_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnCreate_Click(object sender, EventArgs e)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into Workout(username, type, duration, calburned) values (@Username, @Type, @Duration, @CalBurned)", con);
        cmd.Parameters.AddWithValue("Username", usernameLabel.Text);
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
        int totalTime1 = 0;
        int totalCal1 = 0;
        con.Open();
        SqlCommand cmd = new SqlCommand("Select Type, duration, calburned FROM WorkOut where username = '" + usernameLabel.Text + "'", con);
        SqlDataReader dr = cmd.ExecuteReader();
        grid.DataSource = dr;
        grid.DataBind();
        con.Close();
        con.Open();
        SqlCommand cmd1 = new SqlCommand("Select duration, calburned FROM WorkOut where username = '" + usernameLabel.Text + "'", con);
        SqlDataReader dr1 = cmd1.ExecuteReader();
        while (dr1.Read())
        {
            totalTime1 += (int)dr1.GetValue(0); 
            totalCal1 += (int)dr1.GetValue(1); 
        }
        con.Close();

        totalCal.Text = " "+totalCal1;
        totalTime.Text = " " + totalTime1;
    }
}