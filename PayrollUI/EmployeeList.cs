using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PayrollUI
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeSearchButton_Click(object sender, EventArgs e)
        {
            string searchText = EmployeeSearchBox.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a name.");
                return;
            }
            string ConnectionString = "(localdb)\\MSSQLLocalDB  (LAPTOP-871MLHAT\\kiera);Initial Catalog=SQLQuery.sql";

            using (SqlConnection Connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Connection.Open();
                    string sqlQuery = "SELECT EmployeeName FROM Employees WHERE EmployeeName LIKE @searchText";
                    SqlCommand command = new SqlCommand(sqlQuery, Connection);
                    command.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); 
                    DataTable results = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(results);

                    EmployeeSearchResultsList.Items.Clear(); 
                    foreach (DataRow row in results.Rows)
                    {
                        EmployeeSearchResultsList.Items.Add(row["EmployeeName"].ToString()); 
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error connecting to database: " + ex.Message);
                }
            }
        }

        private void EmployeeSearchResultsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

