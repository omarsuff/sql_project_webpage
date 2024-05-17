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
    public partial class Communication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand SendMessage = new SqlCommand("ReceiveMoney", conn);

            SendMessage.CommandType = CommandType.StoredProcedure;

            SendMessage.Parameters.AddWithValue("@sender_id", SenderID1.Text);
            SendMessage.Parameters.AddWithValue("@receiver_id", ReceiverID1.Text);
            SendMessage.Parameters.AddWithValue("@title", Title.Text);
            SendMessage.Parameters.AddWithValue("@timesent", TimeSent.Text);
            SendMessage.Parameters.AddWithValue("@timereceived", TimeReceived.Text);

            SqlCommand CheckAdmin = new SqlCommand("ViewProfile", conn);
            CheckAdmin.CommandType = CommandType.StoredProcedure;
            int userId = Convert.ToInt32(Session["user"]);
            CheckAdmin.Parameters.AddWithValue("@user_id", userId);

            conn.Open();
            SqlDataReader reader = CheckAdmin.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string isAdmin = reader["type"].ToString();
                    if (isAdmin == "admin")
                    {

                        Button2.Visible = true;


                    }
                }


            }
            reader.Close();

        }
        protected void SendMessageButton_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand sendMessage = new SqlCommand("SendMessage", conn))
                {
                    sendMessage.CommandType = CommandType.StoredProcedure;

                    // Set parameters using values from TextBoxes
                    sendMessage.Parameters.AddWithValue("@sender_id", Convert.ToInt32(SenderID1.Text));
                    sendMessage.Parameters.AddWithValue("@receiver_id", Convert.ToInt32(ReceiverID1.Text));
                    sendMessage.Parameters.AddWithValue("@title", Title.Text);
                    sendMessage.Parameters.AddWithValue("@content", Content.Text);
                    sendMessage.Parameters.AddWithValue("@timesent", TimeSpan.Parse(TimeSent.Text));
                    sendMessage.Parameters.AddWithValue("@timereceived", TimeSpan.Parse(TimeReceived.Text));

                    // Open connection and execute the stored procedure
                    conn.Open();
                    sendMessage.ExecuteNonQuery();
                }
            }
        }
        protected void ShowUserMessages(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand showMessages = new SqlCommand("ShowMessages", conn))
                {
                    showMessages.CommandType = CommandType.StoredProcedure;

                    // Assuming ReceiverID2.Text corresponds to @user_id
                    showMessages.Parameters.Add(new SqlParameter("@user_id", ReceiverID2.Text));

                    showMessages.Parameters.Add(new SqlParameter("@sender_id", SenderID2.Text));

                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(showMessages))
                    {
                        adapter.Fill(dt);
                    }

                    // Bind the data to the GridView
                    MessagesGridView.DataSource = dt;
                    MessagesGridView.DataBind();

                }
            }
        }

        protected void Delete(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand Delete1 = new SqlCommand("DeleteMsg", conn))
                {
                    Delete1.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    Delete1.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }


    }
}