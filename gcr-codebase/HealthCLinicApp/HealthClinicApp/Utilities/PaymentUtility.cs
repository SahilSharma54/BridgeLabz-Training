using Microsoft.Data.SqlClient;
using System;

class PaymentUtility
{
    public void RecordPayment()
    {
        Console.Write("Enter Bill ID: ");
        int billId = int.Parse(Console.ReadLine());

        Console.Write("Payment Mode (Cash/Card/UPI): ");
        string mode = Console.ReadLine();

        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_record_payment", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@bill_id", billId);
            cmd.Parameters.AddWithValue("@payment_mode", mode);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Payment recorded.");
        }
    }
}
