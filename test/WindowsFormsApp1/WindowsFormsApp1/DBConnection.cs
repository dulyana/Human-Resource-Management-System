using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class DBConnection
    {
        private static string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sasindu amanda\Documents\add.mdf;Integrated Security=True;Connect Timeout=30";
        private SqlConnection conn;

        /// <summary>
        /// this returns the dataString 
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenDBConnection()
        {
            try

            {
                conn = new SqlConnection(connectionstring);
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }
    }
}

