using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MongoDB.Driver.Core.Configuration;
public class CreateTeamDatabase
{
    public string connectionString = "(localdb)\\MSSQLLocalDB (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql"; // Replace with your actual connection string
    public void CreateTableIfNotExists()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            // Check if the table exists
            string checkTableExistsSql = @"
                IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Teams')
                BEGIN
                    CREATE TABLE Teamss (
                        TeamName nvarchar(50) PRIMARY KEY UNIQUE NOT NULL,
                        TeamDepartment nvarchar(50),
                        TeamLeader nvarchar(50),
                        TeamEmployees nvarchar(MAX)
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
public class Team
{
    public string teamName { get; set; }
    public string teamDepartment { get; set; }
    public string teamLeader { get; set; }
    public List<string> teamEmployees { get; set; }

    public Team(string TeamName, string TeamDepartment, string TeamLeader ,List<string> TeamEmployees)
    { this.teamName = TeamName; this.teamDepartment = TeamDepartment; this.teamLeader = TeamLeader; this.teamEmployees = TeamEmployees; }
}