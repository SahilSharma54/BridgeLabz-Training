using Microsoft.Data.SqlClient;
using System;

class DoctorUtility
{
    public void AddDoctor()
    {
        Console.Write("Enter Doctor Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Specialty ID: ");
        int specialtyId = int.Parse(Console.ReadLine());

        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_add_doctor", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@specialty_id", specialtyId);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Doctor added successfully.");
        }
    }
}
