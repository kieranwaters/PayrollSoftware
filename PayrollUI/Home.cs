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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentButton_Click(object sender, EventArgs e)
        {
            DepartmentAndTeams Department = new DepartmentAndTeams();
            Department.Show();
        }

        private void PayrollMenuButton_Click(object sender, EventArgs e)
        {
            PayrollList makePayroll = new PayrollList();
            makePayroll.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddEmployee newEmployee = new AddEmployee();
            newEmployee.Show();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            Login loginScreen = new Login();
            loginScreen.Show();
        }

        private void EmployeeDatabaseButton_Click(object sender, EventArgs e)
        {
            EmployeeList employeeSearch = new EmployeeList();
            employeeSearch.Show();
        }

        private void EmployeeSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = EmployeeSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a name or employee detils.");
                return;
            }
            string ConnectionString = "(localdb)\\MSSQLLocalDB  (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Connection.Open();
                    // TODO SET UP TABLE FOR EMPLOYEES
                    string sqlQuery = "SELECT [ColumnToSearch] FROM [YourTable] WHERE [ColumnToSearch] LIKE @searchText";
                    SqlCommand command = new SqlCommand(sqlQuery, Connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                    DataTable results = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(results);

                    EmployeeList.Items.Clear();
                    foreach (DataRow row in results.Rows)
                    {
                        EmployeeList.Items.Add(row["ColumnToSearch"].ToString());
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }
    }
}

