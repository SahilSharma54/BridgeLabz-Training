using Microsoft.Data.SqlClient;

class DbConnection
{
    public static SqlConnection GetConnection()
    {
        string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=HealthClinic_DB;Trusted_Connection=true;TrustServerCertificate=true;";
        return new SqlConnection(connectionString);
    }
}
