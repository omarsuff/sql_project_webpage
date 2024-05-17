using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeSync
{
    public partial class Finance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand ReceiveMoney = new SqlCommand("ReceiveMoney", conn);



            ReceiveMoney.CommandType = CommandType.StoredProcedure;

            ReceiveMoney.Parameters.AddWithValue("@receiver_id", ReciverID.Text);
            ReceiveMoney.Parameters.AddWithValue("@type", Type.Text);
            ReceiveMoney.Parameters.AddWithValue("@amount", Amount.Text);
            ReceiveMoney.Parameters.AddWithValue("@status", Status.Text);
            ReceiveMoney.Parameters.AddWithValue("@date", Date.Text);

          

        }

        protected void InsertButton_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand receiveMoney = new SqlCommand("ReceiveMoney", conn))
                {
                    receiveMoney.CommandType = CommandType.StoredProcedure;

                    receiveMoney.Parameters.AddWithValue("@receiver_id", Convert.ToInt32(ReciverID.Text));
                    receiveMoney.Parameters.AddWithValue("@type", Type.Text);
                    receiveMoney.Parameters.AddWithValue("@amount", Convert.ToDecimal(Amount.Text));
                    receiveMoney.Parameters.AddWithValue("@status", Status.Text);
                    receiveMoney.Parameters.AddWithValue("@date", Convert.ToDateTime(Date.Text));

                    conn.Open();
                    receiveMoney.ExecuteNonQuery();

                    conn.Close();
                    Response.Write("Transaction Successful");
                }
            }
        }
        protected void PlanPaymentButton_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["HomeSyncConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand planPayment = new SqlCommand("PlanPayment", conn))
                {
                    planPayment.CommandType = CommandType.StoredProcedure;

                    // Set parameters using values from TextBoxes
                    planPayment.Parameters.AddWithValue("@sender_id", Convert.ToInt32(SenderID.Text));
                    planPayment.Parameters.AddWithValue("@receiver_id", Convert.ToInt32(ReceiverID1.Text));
                    planPayment.Parameters.AddWithValue("@amount", Convert.ToDecimal(Amount2.Text));
                    planPayment.Parameters.AddWithValue("@status", Status2.Text);
                    planPayment.Parameters.AddWithValue("@deadline", Convert.ToDateTime(DeadlineDate.Text));

                    // Open connection and execute the stored procedure
                    conn.Open();
                    planPayment.ExecuteNonQuery();
                    conn.Close();
                    Response.Write("Payment Date Recorded Successfully");

                }
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

