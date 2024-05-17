using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Runtime.Remoting.Messaging;

namespace HomeSync
{
    public partial class Device : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand ViewDevice = new SqlCommand("ViewMyDeviceCharge", conn);
            

           
            ViewDevice.CommandType = CommandType.StoredProcedure;

            ViewDevice.Parameters.AddWithValue("@device_id", Deviceid.Text);
            ViewDevice.Parameters.Add("@charge", SqlDbType.Int).Direction = ParameterDirection.Output;
            ViewDevice.Parameters.Add("@location", SqlDbType.Int).Direction = ParameterDirection.Output;


            

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
                        addButton.Visible = true;
                        Button1.Visible = true;
                        Button2.Visible = true;
                        Button3.Visible = true;
                        Status2.Visible = true;
                        Battery2.Visible = true;
                        Location2.Visible = true;
                        Type2.Visible = true;
                        DeviceID2.Visible = true;
                        addButton.Visible = true;
                        devicelbl.Visible = true;
                        Statuslbl.Visible = true;
                        typelbl.Visible = true;
                        BatteryLabel.Visible = true;
                        locationlbl.Visible = true;
                        insretlbl.Visible = true;
                    }
                }
                
               
            }
            reader.Close();

           
            ViewDevice.ExecuteNonQuery();

            if (ViewDevice.Parameters["@charge"].Value != DBNull.Value)
            {
                int charge = Convert.ToInt32(ViewDevice.Parameters["@charge"].Value);
              
                lbldevice.InnerText = $"Charge for the device : {charge}";

            }
            else
            {
               
                lbldevice.InnerText = "";
            }
            if (ViewDevice.Parameters["@location"].Value != DBNull.Value)
            {
                int room = Convert.ToInt32(ViewDevice.Parameters["@location"].Value);

                lblRoom.InnerText = $"Room Number : {room}";

            }
            else
            {

                lblRoom.InnerText = "";
            }
            
           
            

            conn.Close();
           

        }
        protected void Insert(object sender, EventArgs e)


        {

            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand addDevice = new SqlCommand("AddDevice", conn);
            addDevice.CommandType = CommandType.StoredProcedure;

            addDevice.Parameters.AddWithValue("@device_id", DeviceID2.Text);
            addDevice.Parameters.AddWithValue("@status", Status2.Text);
            addDevice.Parameters.AddWithValue("@battery", Battery2.Text);
            addDevice.Parameters.AddWithValue("@location", Location2.Text);
            addDevice.Parameters.AddWithValue("@type", Type2.Text);

            conn.Open();
            
          
            addDevice.ExecuteNonQuery();
            conn.Close();
            Response.Write("Successfully added");
        }

        protected void Dead(object sender, EventArgs e)


        {

            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand OFB = new SqlCommand("OutOfBattery", conn);
            OFB.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(OFB);
            DataTable dt = new DataTable();

            conn.Open();
            adapter.Fill(dt);
            conn.Close();
            GV.DataSource = dt;
            GV.DataBind();

        }

        protected void Recharged(object sender, EventArgs e)


        {

            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand Charge = new SqlCommand("Charging", conn);
            Charge.CommandType = CommandType.StoredProcedure;


            conn.Open();
            Charge.ExecuteNonQuery();
            conn.Close();
            Response.Write("Successfully added");


        }

        protected void Dead2(object sender, EventArgs e)


        {

            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            SqlCommand needc = new SqlCommand("NeedCharge", conn);
            needc.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter adapter1 = new SqlDataAdapter(needc);
            DataTable dt1 = new DataTable();

            conn.Open();
            adapter1.Fill(dt1);
            conn.Close();
            GV2.DataSource = dt1;
            GV2.DataBind();


        }

    }
}