using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeSync
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void login(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            
                string email = username.Text;
                string Pass = password.Text;
                SqlCommand loginproc = new SqlCommand("UserLogin", conn);
                loginproc.CommandType = CommandType.StoredProcedure;

              
                loginproc.Parameters.AddWithValue("@email", email);
                loginproc.Parameters.AddWithValue("@password", Pass);

               
                loginproc.Parameters.Add("@success", SqlDbType.Bit).Direction = ParameterDirection.Output;
                loginproc.Parameters.Add("@user_id", SqlDbType.Int).Direction = ParameterDirection.Output;

                conn.Open();
                loginproc.ExecuteNonQuery();
                conn.Close();

                bool success = (bool)loginproc.Parameters["@success"].Value;
                int? userId = null; 

                object userIdValue = loginproc.Parameters["@user_id"].Value;
                if (userIdValue != DBNull.Value) 
                {
                    userId = Convert.ToInt32(userIdValue); 
                }

                if (success && userId != null)
                {
                    Session["user"] = userId;
                    Response.Write("Welcome");
                    Response.Redirect("Profile.aspx");
                }
                else
                {
                    Response.Write("incorrect name or password");
                }

            
        }

        protected void signup1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }
    }
}