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
using PayrollUI;
using static PayrollUI.CreateDepartment;

namespace PayrollUI
{
    public partial class CreateTeam : Form
    {
        public CreateTeam()
        {
            InitializeComponent();
        }

        private void SaveTeamButton_Click(object sender, EventArgs e)
        { }
        public class Team
        {
            public string TeamName { get; set; }
            public string TeamDepartment { get; set; }
            public string TeamLeader { get; set; }
            public List<string> TeamEmployees { get; set; }

            public Team(string teamName, string teamDepartment, string teamLeader, List<string> teamEmployees)
            { this.TeamName = teamName; this.TeamDepartment = teamDepartment; this.TeamLeader = teamLeader; this.TeamEmployees = teamEmployees; }
        }

        private void TeamLeaderTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class TeamDataLayer
    {
        public static void AddTeamToDatabase(string connectionString, Team team)
        {
            // SQL query to insert department details
            string sql = @"
            INSERT INTO Teams (
                TeamName,
                TeamDepartment,
                TeamLeader,
                TeamEmployees
            )
            VALUES (
                @teamName,
                @teamDepartment,
                @teamLeader,
                @teamEmployees
            )";

            string teamEmployees = string.Join(",", team.teamEmployees);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sql, connection);

                    // Add parameters to the SQL command
                    command.Parameters.AddWithValue("@teamName", team.teamName);
                    command.Parameters.AddWithValue("@teamDepartment", team.teamDepartment);
                    command.Parameters.AddWithValue("@teamLeader", team.teamLeader);
                    command.Parameters.AddWithValue("@teamEmployees", teamEmployees);

                    // Execute the insert command
                    int rowsAffected = command.ExecuteNonQuery();

                    // Check if any rows were affected
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Team added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected. Team may not have been added.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error adding Department: " + ex.Message);
                }
            }
        }

    }

    public partial class AddTeamData : Form
    {
        private string connectionString;

        public AddTeamData()
        {
            connectionString = "(localdb)\\MSSQLLocalDB (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";
        }
        public System.Windows.Forms.TextBox TeamNameTextBox { get; private set; }
        public System.Windows.Forms.ComboBox DepartmentComboBox { get; private set; }
        public System.Windows.Forms.TextBox TeamLeaderTextBox { get; private set; } 
        public System.Windows.Forms.ListBox EmployeeListBox { get; private set; }

        private void SaveDepartmentButton_Click(object sender, EventArgs e)
        {
            string teamName = GetTextBoxValue(TeamNameTextBox);
            string teamDepartment = DepartmentComboBox.SelectedText;
            string teamLeader = GetTextBoxValue(TeamLeaderTextBox);
            List<string> teamEmployees = new List<string>();
            foreach (object Employee in EmployeeListBox.SelectedItems)
            {
                teamEmployees.Add(Employee.ToString());
            }
            Team newTeam = new Team(teamName, teamDepartment,teamLeader, teamEmployees);
            TeamDataLayer.AddTeamToDatabase(connectionString, newTeam);
        }
        private string GetTextBoxValue(System.Windows.Forms.TextBox textBox)
        {
            return string.IsNullOrEmpty(textBox.Text) ? null : textBox.Text.Trim();
        }

        private List<string> GetTeamEmployeesFromListBox(ListBox listBox)
        {
            List<string> employees = new List<string>();
            foreach (object item in listBox.SelectedItems)
            {
                employees.Add(item.ToString());
            }
            return employees;
        }

        private void TeamNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FindEmployeeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {

        }
    }
}