using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DSM
{
    public class ConnectionFactory
    {
        static OleDbConnection conn = new OleDbConnection();

        private static string connS = @"Provider=Microsoft.ACE.OLEDB.12.0;Jet OLEDB:Database Password=ee105055;Data Source=" + DSM.Properties.Settings.Default.BD;

        public static IDbConnection GetConnection()
        {
            try
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn = new  OleDbConnection(connS);
                    conn.Open();
                }
                return conn;
            }
            catch (Exception ex)
            {

                System.Windows.Forms.MessageBox.Show(ex.Message);
                Path path = new Path();
                path.ShowDialog();
               
                conn.Close();
                return null;
                
            }
        }
    }

    }

