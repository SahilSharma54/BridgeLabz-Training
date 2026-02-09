using Microsoft.Data.SqlClient;
using System;

class PrescriptionUtility
{
    public void AddPrescription()
    {
        Console.Write("Enter Visit ID: ");
        int visitId = int.Parse(Console.ReadLine());

        Console.Write("Medicine Name: ");
        string medicine = Console.ReadLine();

        Console.Write("Dosage: ");
        string dosage = Console.ReadLine();

        Console.Write("Duration: ");
        string duration = Console.ReadLine();

        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_add_prescription", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@visit_id", visitId);
            cmd.Parameters.AddWithValue("@medicine_name", medicine);
            cmd.Parameters.AddWithValue("@dosage", dosage);
            cmd.Parameters.AddWithValue("@duration", duration);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Prescription added.");
        }
    }
}
