using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection.Emit;
using System.Diagnostics;

namespace HomeSync
{
    public partial class Task : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand ViewTask = new SqlCommand("ViewMyTask", conn);
            ViewTask.CommandType = CommandType.StoredProcedure;
            ViewTask.Parameters.Add(new SqlParameter("@user_id", Session["user"]));

            DataTable tabletask = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(ViewTask))
            {
                adapter.Fill(tabletask);
            }


            conn.Close();
            tasktable1.DataSource = tabletask;
            tasktable1.DataBind();

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand FinishMyTask = new SqlCommand("FinishMyTask", conn))
                {
                    FinishMyTask.CommandType = CommandType.StoredProcedure;
                    FinishMyTask.Parameters.Add(new SqlParameter("@user_id", Session["user"]));
                    FinishMyTask.Parameters.Add(new SqlParameter("@title", TextBox1.Text));
                    Debug.WriteLine(Session["user"]);
                    Debug.WriteLine(TextBox1.Text);
                    conn.Open();
                    FinishMyTask.ExecuteNonQuery();
                    conn.Close();

                }
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand viewstatus = new SqlCommand("ViewTask", conn);
            viewstatus.CommandType = CommandType.StoredProcedure;
            viewstatus.Parameters.Add(new SqlParameter("@user_id", Session["user"]));
            viewstatus.Parameters.Add(new SqlParameter("@creator", Int16.Parse(TextBox4.Text)));


            DataTable stat = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(viewstatus))
            {
                adapter.Fill(stat);
            }

            conn.Close();
            GridView1.DataSource = stat;
            GridView1.DataBind();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand reminder = new SqlCommand("AddReminder", conn);
            reminder.CommandType = CommandType.StoredProcedure;
            reminder.Parameters.Add(new SqlParameter("@task_id", TextBox3.Text));
            reminder.Parameters.Add(new SqlParameter("@reminder", TextBox2.Text));

            conn.Open();
            reminder.ExecuteNonQuery();
            conn.Close();
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand update = new SqlCommand("UpdateTaskDeadline", conn);
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.Add(new SqlParameter("@task_id", TextBox7.Text));
            update.Parameters.Add(new SqlParameter("@deadline", TextBox6.Text));

            conn.Open();
            update.ExecuteNonQuery();
            conn.Close();


        }
    }
}

