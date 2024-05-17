using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Web.UI.WebControls;

namespace HomeSync
{
    public partial class Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(connStr);

                SqlCommand ViewProfileCmd = new SqlCommand("ViewProfile", conn);
                ViewProfileCmd.CommandType = CommandType.StoredProcedure;

               
                int userId = Convert.ToInt32(Session["user"]);

                ViewProfileCmd.Parameters.AddWithValue("@user_id", userId);

                conn.Open();
                SqlDataReader reader = ViewProfileCmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                       
                        string firstName = reader["f_Name"].ToString();
                        string lastName = reader["l_Name"].ToString();
                        string email = reader["email"].ToString();
                        int age = Convert.ToInt32(reader["age"]);
                        DateTime birthDate = Convert.ToDateTime(reader["birthdate"]);
                        string type = reader["type"].ToString();
                        string preference = reader["preference"].ToString();
                        String room = reader["room_id"].ToString();

                      
                        lblName.InnerText = $"{firstName} {lastName}";
                        lblEmail.InnerText = email;
                        lblAge.InnerText = age.ToString();
                        lblBirthDate.InnerText = birthDate.ToShortDateString();
                        lblType.InnerText = type;
                        lblPreference.InnerText = preference;
                        lblroom.InnerText = room;

                        lblName.Style["font-size"] = "24px";
                        lblEmail.Style["font-size"] = "24px";
                        lblAge.Style["font-size"] = "24px";
                        lblBirthDate.Style["font-size"] = "24px";
                        lblType.Style["font-size"] = "24px";
                        lblPreference.Style["font-size"] = "24px";
                      

                    }
                

                conn.Close();
            }
        }
        protected void Navigate(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            switch (clickedButton.ID)
            {
                case "Button6":
                    Response.Redirect("Device.aspx");
                    break;
              
                default:
                    
                    break;
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            bool isAdmin = CheckIfUserIsAdmin(Session["user"]); 

            if (isAdmin)
            {
                Response.Redirect("AdminEvents.aspx"); 
            }
            else
            {
                Response.Redirect("Events.aspx"); 
            }
        }
        private bool CheckIfUserIsAdmin(object userId)
        {
            bool isAdmin = false;

            if (userId != null)
            {
                int user = Convert.ToInt32(userId);

               
                string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Admin WHERE admin_id = @userId", conn);
                    cmd.Parameters.AddWithValue("@userId", user);

                    conn.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    conn.Close();

                    isAdmin = (count > 0);
                }
            }

            return isAdmin;
        }

        protected void Button9_Click1(object sender, EventArgs e)
        {

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("Task.aspx");
        }

        protected void gotoroom(object sender, EventArgs e)
        {
            bool isAdmin = CheckIfUserIsAdmin(Session["user"]);

            if (isAdmin)
            {
                Response.Redirect("Room.aspx");
            }
            else
            {
                Response.Redirect("Room.aspx");
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("Communication.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("Finance.aspx");
        }

        protected void adminguests(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand procedure = new SqlCommand("GuestNumber", conn);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add(new SqlParameter("@admin_id", SqlDbType.Int));
            String admin = admin_id.Text;
            procedure.Parameters["@admin_id"].Value = admin;
            DataTable table = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(procedure))
            {
                adapter.Fill(table);
            }

            conn.Close();


            guestnumber.DataSource = table;
            guestnumber.DataBind();


        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
   }

