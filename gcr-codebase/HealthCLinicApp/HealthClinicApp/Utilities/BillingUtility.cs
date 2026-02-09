using Microsoft.Data.SqlClient;
using System;

class BillingUtility
{
    public void GenerateBill()
    {
        Console.Write("Enter Visit ID: ");
        int visitId = int.Parse(Console.ReadLine());

        Console.Write("Enter Amount: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_generate_bill", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@visit_id", visitId);
            cmd.Parameters.AddWithValue("@amount", amount);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Bill generated successfully.");
        }
    }

    public void ViewOutstandingBills()
    {
    using (SqlConnection conn = DbConnection.GetConnection())
    {
        string query = @"
        SELECT b.bill_id, p.name, b.amount
        FROM bills b
        JOIN visits v ON b.visit_id = v.visit_id
        JOIN appointments a ON v.appointment_id = a.appointment_id
        JOIN patients p ON a.patient_id = p.patient_id
        WHERE b.status = 'UNPAID'";

        SqlCommand cmd = new SqlCommand(query, conn);

        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(
                reader["bill_id"] + " | " +
                reader["name"] + " | " +
                reader["amount"]
            );
        }

        reader.Close();
        conn.Close();
    }
}


}
