using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;
class ProgramDepartmentAndTeamsSearch
{
    static void Main()
    {
        SqlConnection connection2 = new SqlConnection();
        using (connection2);
    }
}
public class CreateDepartmentDatabase
{
    public string connectionString = "(localdb)\\MSSQLLocalDB (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql"; // Replace with your actual connection string

    public void CreateTableIfNotExists()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Check if the table exists
            string checkTableExistsSql = @"
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Departments')
                BEGIN
                    CREATE TABLE Departments (
                        DepartmentName nvarchar(50) PRIMARY KEY UNIQUE NOT NULL,
                        DepartmentTeams nvarchar(MAX)
                    );
                END;
            ";

            try
            {
                SqlCommand checkCommand = new SqlCommand(checkTableExistsSql, connection);
                checkCommand.ExecuteNonQuery();
                Console.WriteLine("Table 'Departments' created (if it didn't exist already).");
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine("Error checking/creating table: Departments" + ex.Message);
            }
        }
    }
}
public class Department
{
    public string departmentName { get; set; }
    public List<string> departmentTeams { get; set; }

    public Department(string DepartmentName, List<string> DepartmentTeams)
    { this.departmentName = DepartmentName; this.departmentTeams = DepartmentTeams; }
}