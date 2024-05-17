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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void register(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String usernameuser = username.Text;
            String emailuser = email.Text;
            String passUser = password.Text;
            String fnameUser = fname.Text;
            String lnameUser = lname.Text;
            String birthdate = birth.Text;
            String usertype = type.Text;


            SqlCommand registerprocedure = new SqlCommand("UserRegister", conn);
            registerprocedure.CommandType = CommandType.StoredProcedure;
            registerprocedure.Parameters.Add(new SqlParameter("@email", emailuser));
            registerprocedure.Parameters.Add(new SqlParameter("@userName", emailuser));
            registerprocedure.Parameters.Add(new SqlParameter("@password", passUser));
            registerprocedure.Parameters.Add(new SqlParameter("@first_name",fnameUser));
            registerprocedure.Parameters.Add(new SqlParameter("@last_name", lnameUser));
            registerprocedure.Parameters.Add(new SqlParameter("@birth_date", birthdate));
            registerprocedure.Parameters.Add(new SqlParameter("@usertype", usertype));
            SqlParameter userId = registerprocedure.Parameters.Add(new SqlParameter("@user_id", SqlDbType.Int));
            userId.Direction = ParameterDirection.Output;

            conn.Open();
            registerprocedure.ExecuteNonQuery();
            conn.Close();
            int? finuserId = null;

            object userIdValue = registerprocedure.Parameters["@user_id"].Value;
            if (userIdValue != DBNull.Value)
            {
                finuserId = Convert.ToInt32(userIdValue);
            }

            if (userId != null)
            {
                Session["user"] = finuserId;
                Response.Write("Welcome");
                Response.Redirect("Profile.aspx");
            }
         

        }
    }
}