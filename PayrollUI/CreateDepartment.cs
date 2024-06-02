using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Pdf.Operators;
using MongoDB.Driver.Core.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PayrollUI
{
    public partial class CreateDepartment : Form
    {
        private string connectionString = "(localdb)\\MSSQLLocalDB (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";
        public CreateDepartment()
        {
            InitializeComponent();

        }

        public void SelectedTeamsListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateDepartment_Load(object sender, EventArgs e)
        {

        }

        private void EnterDepartmentNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveDepartmentButton_Click(object sender, EventArgs e)
        { }


        public class Department
        {
            public string DepartmentName { get; set; }
            public List<string> DepartmentTeams { get; set; }

            public Department(string departmentName, List<string> departmentTeams)
            {
                DepartmentName = departmentName;
                DepartmentTeams = departmentTeams;
            }
        }

        public class DepartmentDataLayer
        {
            public static void AddDepartmentToDatabase(string connectionString, Department department)
            {
                // SQL query to insert department details
                string sql = @"
            INSERT INTO Departments (
                DepartmentName,
                Teams
            )
            VALUES (
                @departmentName,
                @teamList
            )";

                string teamList = string.Join(",", department.DepartmentTeams);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(sql, connection);

                        // Add parameters to the SQL command
                        command.Parameters.AddWithValue("@departmentName", department.DepartmentName);
                        command.Parameters.AddWithValue("@teamList", teamList);

                        // Execute the insert command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if any rows were affected
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Department added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("No rows affected. Department may not have been added.");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error adding Department: " + ex.Message);
                    }
                }
            }

        }
    }
    public partial class AddDepartmentData : Form
    {
        private string connectionString;

        public AddDepartmentData()
        {
            connectionString = "(localdb)\\MSSQLLocalDB (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";
        }
        public System.Windows.Forms.TextBox EnterDepartmentNameBox { get; private set; }
        public System.Windows.Forms.ListBox SelectedTeamsListBox1 { get; private set; }

        private void SaveDepartmentButton_Click(object sender, EventArgs e)
        {
            string departmentName = GetTextBoxValue(EnterDepartmentNameBox); // Assuming control is linked
            List<string> departmentTeams = GetDepartmentTeamsFromListBox(SelectedTeamsListBox1); // Assuming control is linked
            CreateDepartment.Department newDepartment = new CreateDepartment.Department(departmentName, departmentTeams);
            CreateDepartment.DepartmentDataLayer.AddDepartmentToDatabase(connectionString, newDepartment);
        }
        private string GetTextBoxValue(System.Windows.Forms.TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text) ? null : textBox.Text.Trim();
        }

        private List<string> GetDepartmentTeamsFromListBox(ListBox listBox)
        {
            List<string> teams = new List<string>();
            foreach (object item in listBox.SelectedItems)
            {
                teams.Add(item.ToString());
            }
            return teams;
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {

        }
    }
}
