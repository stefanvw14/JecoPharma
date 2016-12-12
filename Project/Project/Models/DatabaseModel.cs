using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class DatabaseModel
    {
        protected static string connect()
        {
            string conn = System.Configuration.ConfigurationManager.ConnectionStrings["JeCoPharmaDB"].ConnectionString;
            return conn;
        }

        public static DataTable select(string query, object[] parameters)
        {
            DataTable dt = new DataTable();

            // Connectionstring in code aanmaken:
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connect();
            // Een OleDBCommand gebruiken:
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            for (int i = 0; i < parameters.Length; i++)
            {
                cmd.Parameters.Add(new SqlParameter("@p" + i, parameters[i]));
            }
            cmd.Connection = conn;

            try
            {
                // Query de database en maak hiervan een dataset
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message.ToString()); }
            finally { conn.Close(); }

            // Return de DataSet
            return dt;
        }

        public static void execute(string query, object[] parameters)
        {

            // Connectionstring in code aanmaken:
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = connect();
            // Een OleDBCommand gebruiken:
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query;

            for (int i = 0; i < parameters.Length; i++)
            {
                if (parameters[i] != "" || parameters[i] != null)
                {
                    cmd.Parameters.Add(new SqlParameter("@p" + i, parameters[i]));
                }
            }
            cmd.Connection = conn;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message.ToString()); }
            finally { conn.Close(); }

        }
    }
}