using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeSync
{
    public partial class Room : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String user = Session["user"].ToString();
            SqlCommand procedure = new SqlCommand("UserRoomID", conn);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add(new SqlParameter("@user_id", Session["user"]));
            SqlParameter Roomid = procedure.Parameters.Add(new SqlParameter("@room_id", SqlDbType.Int));
            Roomid.Direction = ParameterDirection.Output;
            conn.Open();
            procedure.ExecuteNonQuery();
            conn.Close();
            int roomIdValue =0;
            if (Roomid.Value == DBNull.Value) ;
            else
            {
                roomIdValue = Convert.ToInt32(Roomid.Value);
            }
            
            roomid.Text = roomIdValue.ToString();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            String room = room_id.Text;

            SqlCommand procedure = new SqlCommand("AssignRoom", conn);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add(new SqlParameter("@user_id", Session["user"]));
            procedure.Parameters.Add(new SqlParameter("@room_id", room));
            conn.Open();
            procedure.ExecuteNonQuery();
            conn.Close();
            Response.Write("booked this room");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand procedure = new SqlCommand("RoomAvailability", conn);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add(new SqlParameter("@status", statusstatus.Text));
            procedure.Parameters.Add(new SqlParameter("@location", statusroomid.Text));
            conn.Open();
            procedure.ExecuteNonQuery();
            conn.Close();
            Response.Write("Set Status!");
        }

        protected void statusstatus0_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand procedure = new SqlCommand("CreateSchedule", conn);
            procedure.CommandType = CommandType.StoredProcedure;
            procedure.Parameters.Add(new SqlParameter("@creator_id", Session["user"]));
            procedure.Parameters.Add(new SqlParameter("@room_id", scheduleroomid.Text));
            procedure.Parameters.Add(new SqlParameter("@start_time", scheduledate.Text));
            procedure.Parameters.Add(new SqlParameter("@end_time", scheduleenddate.Text));
            procedure.Parameters.Add(new SqlParameter("@action", scheduleaction.Text));
            conn.Open();
            procedure.ExecuteNonQuery();
            conn.Close();
            Response.Write("Set Schedule!");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            String connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);


            SqlCommand procedure = new SqlCommand("ViewRoom", conn);
            DataTable table = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(procedure))
            {
                adapter.Fill(table);
            }

            conn.Close();


            emptyrooms.DataSource = table;
            emptyrooms.DataBind();
        }
    }
}