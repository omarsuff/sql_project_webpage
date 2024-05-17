using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Policy;
using System.Threading;

namespace HomeSync
{
    public partial class Events : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand CreateEvent = new SqlCommand("CreateEvent", conn);
                CreateEvent.CommandType = CommandType.StoredProcedure;

                CreateEvent.Parameters.AddWithValue("@event_id", one.Text);
                CreateEvent.Parameters.AddWithValue("@user_id", two.Text);
                CreateEvent.Parameters.AddWithValue("@name", three.Text);
                CreateEvent.Parameters.AddWithValue("@description", four.Text);
                CreateEvent.Parameters.AddWithValue("@location", five.Text);
                CreateEvent.Parameters.AddWithValue("@reminder_date", six.Text);
                CreateEvent.Parameters.AddWithValue("@other_user_id", seven.Text);
                try
                {
                    conn.Open();
                    CreateEvent.ExecuteNonQuery();
                    conn.Close();

                    Response.Write("Successfully added");
                }
                catch (SqlException ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            }
        }
        protected void Button2(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand AssignUser = new SqlCommand("AssignUser", conn);
                AssignUser.CommandType = CommandType.StoredProcedure;

                AssignUser.Parameters.AddWithValue("@user_id", assign1.Text);
                AssignUser.Parameters.AddWithValue("@event_id", assign2.Text);

                try
                {
                    conn.Open();
                    AssignUser.ExecuteNonQuery();

                    SqlDataReader reader = AssignUser.ExecuteReader();


                    conn.Close();

                    Response.Write("Successfully assigned user to event and retrieved data.");
                }
                catch (SqlException ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            }

        }
        protected void Button3(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand Uninvited = new SqlCommand("Uninvited", conn);
                Uninvited.CommandType = CommandType.StoredProcedure;


                Uninvited.Parameters.AddWithValue("@event_id", Un1.Text);
                Uninvited.Parameters.AddWithValue("@user_id", Un2.Text);

                try
                {
                    conn.Open();
                    Uninvited.ExecuteNonQuery();

                    SqlDataReader reader = Uninvited.ExecuteReader();


                    conn.Close();

                    Response.Write("Successfully Uassigned user to event ");
                }
                catch (SqlException ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
            }

        }
        protected void Button4(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand ViewEvent = new SqlCommand("ViewEvent", conn);
                ViewEvent.CommandType = CommandType.StoredProcedure;

                ViewEvent.Parameters.AddWithValue("@User_id", View1.Text);
                ViewEvent.Parameters.AddWithValue("@Event_id", View2.Text);

                DataTable table = new DataTable();

                try
                {
                    conn.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(ViewEvent))
                    {
                        adapter.Fill(table);
                    }

                    ViewTable.DataSource = table;
                    ViewTable.DataBind();
                }
                catch (SqlException ex)
                {
                    Response.Write("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


    }
}

