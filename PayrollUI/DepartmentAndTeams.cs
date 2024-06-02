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

namespace PayrollUI
{
    public partial class DepartmentAndTeams : Form
    {
        public ListBox DepartmentsListBox;

        public DepartmentAndTeams()
        {
            InitializeComponent(); // Call InitializeComponent here

        }

        private void DepartmentsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = DepartmentsSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a department.");
                return;
            }
            string ConnectionString = "(localdb)\\MSSQLLocalDB  (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Connection.Open();
                    // TODO SET UP TABLE FOR DEPARTMENTS
                    string sqlQuery = "SELECT DepartmentName FROM Departments WHERE DepartmentName LIKE @searchText";
                    SqlCommand command = new SqlCommand(sqlQuery, Connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    DataTable results = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(results);

                    DepartmentsListBox.Items.Clear();
                    foreach (DataRow row in results.Rows)
                    {
                        DepartmentListBox.Items.Add(row["DepartmentName"].ToString());
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void DepartmentsSearchBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void DepartmentListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void AddDepartmentButton_Click(object sender, EventArgs e)
        {
            CreateDepartment newDepartment = new CreateDepartment();
            newDepartment.Show();
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            CreateTeam newTeam = new CreateTeam();
            newTeam.Show();

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {

        }

        private void TeamsSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = TeamsSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a team.");
                return;
            }
            string ConnectionString = "(localdb)\\MSSQLLocalDB  (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Connection.Open();
                    // TODO SET UP TABLE FOR TEAMS
                    string sqlQuery = "SELECT [ColumnToSearch] FROM [YourTable] WHERE [ColumnToSearch] LIKE @searchText";
                    SqlCommand command = new SqlCommand(sqlQuery, Connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    DataTable results = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(results);

                    TeamsListBox.Items.Clear();
                    foreach (DataRow row in results.Rows)
                    {
                        TeamsListBox.Items.Add(row["ColumnToSearch"].ToString());
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void TeamsSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

