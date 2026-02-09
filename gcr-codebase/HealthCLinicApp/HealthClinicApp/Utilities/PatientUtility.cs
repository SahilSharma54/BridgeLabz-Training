using Microsoft.Data.SqlClient;
using System;

class PatientUtility : IPatient
{
    public void RegisterPatient()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Phone: ");
        string phone = Console.ReadLine();

        Console.Write("Enter Email: ");
        string email = Console.ReadLine();

        Console.Write("Enter DOB (yyyy-mm-dd): ");
        string dob = Console.ReadLine();

        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_register_patient", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@dob", dob);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Patient registered successfully.");
        }
    }

    public void SearchPatient()
    {
        Console.Write("Enter Phone Number: ");
        string phone = Console.ReadLine();

        using (SqlConnection conn = DbConnection.GetConnection())
        {
            string query = "SELECT * FROM patients WHERE phone=@phone";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@phone", phone);

            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                Console.WriteLine(
                    reader["patient_id"] + " | " +
                    reader["name"] + " | " +
                    reader["email"]
                );
            }
            else
            {
                Console.WriteLine("Patient not found.");
            }

            reader.Close();
            conn.Close();
        }
    }

    public void ViewMedicalHistory()
    {
    Console.Write("Enter Patient ID: ");
    int patientId = int.Parse(Console.ReadLine());

    using (SqlConnection conn = DbConnection.GetConnection())
    {
        string query = @"
        SELECT p.name, v.diagnosis, pr.medicine_name
        FROM patients p
        JOIN appointments a ON p.patient_id = a.patient_id
        JOIN visits v ON a.appointment_id = v.appointment_id
        LEFT JOIN prescriptions pr ON v.visit_id = pr.visit_id
        WHERE p.patient_id = @pid";

        SqlCommand cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@pid", patientId);

        conn.Open();
        SqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine(
                reader["name"] + " | " +
                reader["diagnosis"] + " | " +
                reader["medicine_name"]
            );
        }

        reader.Close();
        conn.Close();
    }

  }


}
