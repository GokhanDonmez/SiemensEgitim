using Microsoft.Data.SqlClient;
using MilcanX.Class.OTHER;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MilcanX.Class.DAL
{
    public class LoginDAL
    {
        static bool _result;
        static SqlConnection conn = new SqlConnection(Connection.ConnectionString);
        public static bool Login(string firstName, string lastName)
        {
            string _firstName = firstName;
            string _lastName = lastName;
            SqlCommand cmd = new SqlCommand("Select * from Employees WHERE FirstName='" + _firstName + "' AND LastName='" + _lastName + "'", conn);
            int _employeeId;


            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                {
                    conn.Open();
                    _employeeId = Convert.ToInt32(cmd.ExecuteScalar());
                    if (_employeeId > 0)
                    {

                        _result = true;
                    }
                    else
                    {
                        MessageBox.Show("Yanlış");
                        _result = false;
                    }
                    //ucPages.ucEkle(MainWindow.test, UserControl1.us1);
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                {
                    conn.Close();
                }
            }
            return _result;
        }
    }
}
