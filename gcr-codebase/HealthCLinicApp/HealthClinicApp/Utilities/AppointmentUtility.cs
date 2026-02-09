using Microsoft.Data.SqlClient;
using System;

class AppointmentUtility
{
    public void BookAppointment()
    {
        Console.Write("Enter Patient ID: ");
        int patientId = int.Parse(Console.ReadLine());

        Console.Write("Enter Doctor ID: ");
        int doctorId = int.Parse(Console.ReadLine());

        Console.Write("Enter Appointment Date (yyyy-mm-dd): ");
        string date = Console.ReadLine();

        using (SqlConnection conn = DbConnection.GetConnection())
        {
            SqlCommand cmd = new SqlCommand("sp_book_appointment", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@patient_id", patientId);
            cmd.Parameters.AddWithValue("@doctor_id", doctorId);
            cmd.Parameters.AddWithValue("@appointment_date", date);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

            Console.WriteLine("Appointment booked successfully.");
        }
    }
}
