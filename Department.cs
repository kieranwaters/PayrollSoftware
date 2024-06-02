using System;

public class CreateDepartmentDatabase
    using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    try
    {
        SqlCommand command = new SqlCommand(sql, connection);
        command.ExecuteNonQuery();
        Console.WriteLine("Table 'Departments' created successfully!");
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Error creating table: Departments" + ex.Message);
    }
}
    }
}
public class Department
{
    string departmentName { get; set; }
    list<string> teams { get; set; }

    public Department(string DepartmentName, list<string> Teams)
    { this.departmentName = DepartmentName; this.teams = Teams; }
}




}



public class CheckTableExists
{
    public static bool DoesTableExist(string connectionString, string tableName)
    {
        string sql = $@"
      SELECT * 
      FROM INFORMATION_SCHEMA.TABLES 
      WHERE TABLE_NAME = '{tableName}'";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataReader reader = command.ExecuteReader();
                return reader.HasRows;
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error checking for table: " + ex.Message);
                // Handle exception appropriately (optional)
                return false; // Assuming table doesn't exist on error
            }
        }
    }
    public class AddDepartmentToDepartmentsDatabase
    {
        public static void AddDepartment(string connectionString, string departmentName List<string> teams)
                               )
    {
        string sql = @"
      INSERT INTO Departments (
        DepartmentName
        Team,
      )
      VALUES (
        @departmentName
        @team,
      )";

        using (SqlConnection connection = new SqlConnection(connectionString))
{
    connection.Open();

    try
    {
        SqlCommand command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Team", teams);

        command.ExecuteNonQuery();
        Console.WriteLine("Department/s: '{0}' added successfully!", teams);
    }
    catch (SqlException ex)
    {
        Console.WriteLine("Error adding Department/s: " + ex.Message);
    }
}
    }

}
}

}
/// Create an Add Department Page