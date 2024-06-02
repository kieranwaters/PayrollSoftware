using System;
using System.Data.SqlClient;

public class DatabaseConnection
{
    public static string ConnectionString = "(localdb)\\MSSQLLocalDB  (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";
    public static SqlConnection GetConnection()
    {
        try
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }
        catch (SqlException ex)
        {
            // Handle connection errors (optional)
            Console.WriteLine("Error connecting to database: " + ex.Message);
            return null; // Or throw an exception depending on your needs
        }
    }
}

