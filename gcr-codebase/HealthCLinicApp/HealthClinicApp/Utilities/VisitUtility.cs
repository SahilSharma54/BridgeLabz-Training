using Microsoft.Data.SqlClient;
using System;

class VisitUtility
{
    public void RecordVisit()
    {
        Console.Write("Enter Appointment ID: ");
        int appointmentId = int.Parse(Console.ReadLine());

        Console.Write("Enter Diagnosis: ");
        string diagnosis = Console.ReadLine();

        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_record_visit", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@appointment_id", appointmentId);
            cmd.Parameters.AddWithValue("@diagnosis", diagnosis);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Visit recorded successfully.");
        }
    }
}
