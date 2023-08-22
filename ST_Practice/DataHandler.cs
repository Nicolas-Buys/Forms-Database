using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace ST_Practice
{
    class DataHandler
    {
        string ConnectionString = "Data Source=localhost;Initial Catalog=BelgiumCampus;Integrated Security=True";

        public DataTable ReadLogin()
        {
            DataTable data = new DataTable();
            string query = @"SELECT * FROM Users";
            SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionString);
            adapter.Fill(data);
            data.AcceptChanges();
            return data;
        }
        // ADD
        public string[] GetInfoAndQuery(string FirstName, string LastName)
        {
            
            string query = $"INSERT INTO [dbo].[Employees]([FirstName],[LastName]) VALUES('{FirstName}', '{LastName}')";
            string message = "Add Successful";
            string[] InfoQuery = { query, message };
            return InfoQuery;
        }
        // Update
        public string[] GetInfoAndQuery(int ID, string FirstName, string LastName)
        {

            string query = $"UPDATE Employees SET FirstName ='{FirstName}',LastName = '{LastName}' WHERE EmployeeID = '{ID}'";
            string message = "Update Successful";
            string[] InfoQuery = { query, message };
            return InfoQuery;
        }
        //Delete
        public string[] GetInfoAndQuery(int ID)
        {

            string query = $"DELETE FROM Employees WHERE EmployeeID = '{ID}'";
            string message = "Delete Successful";
            string[] InfoQuery = { query, message };
            return InfoQuery;
        }
        public void ExecuteQuery(string[] InfoQuery)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                SqlCommand command = new SqlCommand(InfoQuery[0], connection);
                command.ExecuteNonQuery();
                MessageBox.Show(InfoQuery[1]);
                connection.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public DataTable Search(int ID)
        {
            DataTable data = new DataTable();
            try
            {
                
                string query = $"SELECT * FROM Employees WHERE EmployeeID = '{ID}'";
                SqlDataAdapter adapter = new SqlDataAdapter(query, ConnectionString);
                adapter.Fill(data);
                data.AcceptChanges();
                
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                
            }
            return data;
        }
    }
}
