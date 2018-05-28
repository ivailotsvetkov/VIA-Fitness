using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{


    [WebMethod]
    public string GetUsers()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString);
        con.Open();
        SqlCommand cmd = new SqlCommand("Select Username FROM RegistrationTable", con);
        SqlDataReader dr1 = cmd.ExecuteReader();
        String temp = "";
        while (dr1.Read())
        {

            temp += (String)dr1.GetValue(0) + System.Environment.NewLine;
        }
        con.Close();
        return temp;
    }

}
