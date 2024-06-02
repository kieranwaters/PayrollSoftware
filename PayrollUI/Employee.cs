using System;
using System.Collections.Generic;
using System.Data.SqlClient;
public class Employee
{
        public string EmployeeName { get; set; }
        public string EmployeeJob { get; set; }
        public string ManagerName { get; set; }
        public double EmployeeMonthlyPay { get; set; }
        public string EmployeeTeam { get; set; }
        public string NINumber { get; set; }
        public double EmployeeEmployerNI { get; set; }
        public double EmployeePAYENI { get; set; }
        public double EmployeePAYEIncomeTax { get; set; }
        public double EmployeePensionContribution { get; set; }
        public double EmployeeEmployerPensionContribution { get; set; }
    public Employee(string employeeName, string employeeJob, string managerName,
                  double monthlyPay, string team, string nationalInsuranceNumber,
                  double employerNationalInsurance, double employeeNationalInsurance,
                  double employeeIncomeTax, double employeePensionContribution,
                  double employerPensionContribution)
    {
        this.EmployeeName = employeeName;
        this.EmployeeJob = employeeJob;
        this.ManagerName = managerName;
        this.EmployeeMonthlyPay = monthlyPay;
        this.EmployeeTeam = team;
        this.NINumber = nationalInsuranceNumber;
        this.EmployeeEmployerNI = employerNationalInsurance;
        this.EmployeePAYENI = employeeNationalInsurance;
        this.EmployeePAYEIncomeTax = employeeIncomeTax;
        this.EmployeePensionContribution = employeePensionContribution;
        this.EmployeeEmployerPensionContribution = employerPensionContribution;

    }

}
public class CreateEmployeeDetailsDatabase
{
    public static void Main(string[] args)
    {
        string connectionString = DatabaseConnection.ConnectionString;

        string sql = @"
  CREATE TABLE Employees (
    EmployeeID int PRIMARY KEY IDENTITY,  -- Auto-incrementing ID
    EmployeeName nvarchar(50) NOT NULL,
    EmployeeJob nvarchar(50),
    ManagerName nvarchar(50),
    EmployeeMonthlyPay decimal(10,2),  -- Allows for decimal values
    EmployeeTeam nvarchar(50),
    NINumber nvarchar(50),
    EmployeeEmployerNI decimal(10,2),
    EmployeePAYENI decimal(10,2),
    EmployeePAYEIncomeTax decimal(10,2),
    EmployeePensionContribution decimal(10,2),
    EmployeeEmployerPensionContribution decimal(10,2)
  )";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();

            try
            {
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Table 'Employees' created successfully!");
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error creating table: Employees" + ex.Message);
            }
        }
    }
}


public class CheckTableExists
{
    public static bool DoesTableExist(string connectionString, string tableName)
    {
        string sql = $@"
      SELECT * 
      FROM INFORMATION_SCHEMA.TABLES 
      WHERE TABLE_NAME = 'Employees'";

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

    public static void Main(string[] args)
    {
        string connectionString = DatabaseConnection.ConnectionString;
        string tableName = "Employees";

        if (DoesTableExist(connectionString, tableName))
        {
            Console.WriteLine("Table '{0}' already exists.", tableName);
        }
        else
        {
            // Call your code to create the table (assuming CreateEmployeeDetailsDatabase class)
            CreateEmployeeDetailsDatabase.Main(args);
        }
    }
    public class AddEmployeeToEmployeeDetailsDatabase
    {
        public static void AddEmployee(string connectionString,
                                       string employeeName,
                                       string employeeJob,
                                       string managerName,
                                       double monthlyPay,
                                       string team,
                                       string nationalInsuranceNumber,
                                       double employerNationalInsurance,
                                       double employeeNationalInsurance,
                                       double employeeIncomeTax,
                                       double employeePensionContribution,
                                       double employerPensionContribution)
        {
            string sql = @"
      INSERT INTO Employees (
        EmployeeName,
        EmployeeJob,
        ManagerName,
        EmployeeMonthlyPay,
        EmployeeTeam,
        NINumber,
        EmployeeEmployerNI,
        EmployeePAYENI,
        EmployeePAYEIncomeTax,
        EmployeePensionContribution,
        EmployerPensionContribution
      )
      VALUES (
        @EmployeeName,
        @EmployeeJob,
        @ManagerName,
        @EmployeeMonthlyPay,
        @EmployeeTeam,
        @NINumber,
        @EmployeeEmployerNI,
        @EmployeePAYENI,
        @EmployeePAYEIncomeTax,
        @EmployeePensionContribution,
        @EmployerPensionContribution
      )";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@EmployeeName", employeeName);
                    command.Parameters.AddWithValue("@EmployeeJob", employeeJob);
                    command.Parameters.AddWithValue("@ManagerName", managerName);
                    command.Parameters.AddWithValue("@EmployeeMonthlyPay", monthlyPay);
                    command.Parameters.AddWithValue("@EmployeeTeam", team);
                    command.Parameters.AddWithValue("@NINumber", nationalInsuranceNumber);
                    command.Parameters.AddWithValue("@EmployeeEmployerNI", employerNationalInsurance);
                    command.Parameters.AddWithValue("@EmployeePAYENI", employeeNationalInsurance);
                    command.Parameters.AddWithValue("@EmployeePAYEIncomeTax", employeeIncomeTax);
                    command.Parameters.AddWithValue("@EmployeePensionContribution", employeePensionContribution);
                    command.Parameters.AddWithValue("@EmployerPensionContribution", employerPensionContribution);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Employee '{0}' added successfully!", employeeName);
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error adding employee: " + ex.Message);
                }
            }
        }

    }
}

///NEED TO ADD THE ABOVE CLASS/ES TO THE ADD EMPLOYEE BUTTON
