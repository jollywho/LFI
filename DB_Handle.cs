using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;

namespace LFI
{
    class DB_Handle
    {
        static string conn = @"Data Source=" 
            + Folder_IO.GetUserDataPath() + "; foreign_keys = true;";
            
        static SQLiteConnection manual_cnn;
        static bool IsOpen = false;

        /// <summary>
        /// Retrieves datatable from database.
        /// </summary>
        /// <param name="sql">sql string.</param>
        /// <returns>results as datatable.</returns>
        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            SQLiteConnection cnn = new SQLiteConnection(conn);
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql;
            SQLiteDataReader reader = mycommand.ExecuteReader();
            dt.Load(reader);
            reader.Close();
            cnn.Close();
            return dt;
        }

        /// <summary>
        /// Update datatabase.
        /// </summary>
        /// <param name="sql">sql string.</param>
        public static void UpdateTable(string sql)
        {
            SQLiteConnection cnn = new SQLiteConnection(conn);
            cnn.Open();
            SQLiteCommand mycommand = new SQLiteCommand(cnn);
            mycommand.CommandText = sql;
            SQLiteDataReader reader = mycommand.ExecuteReader();
            reader.Close();
            cnn.Close();
        }

        /// <summary>
        /// Open a manual connection to the database for
        /// scalar updates.
        /// </summary>
        public static void OpenConnection()
        {
            try
            {
                manual_cnn = new SQLiteConnection(conn);
                manual_cnn.Open();
                IsOpen = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Execute a scalar update with the open database
        /// connection.
        /// </summary>
        /// <param name="sql">sql string.</param>
        public static void ScalarUpdate(string sql)
        {
            try
            {
                SQLiteCommand mycommmand = new SQLiteCommand(sql, manual_cnn);
                mycommmand.ExecuteScalar();
                mycommmand.CommandText = "SELECT last_insert_rowid()";
                Console.WriteLine(mycommmand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Close the database connection.
        /// </summary>
        public static void CloseConnection()
        {
            if (IsOpen)
            {
                manual_cnn.Close();
                IsOpen = false;
            }
        }
    }


}
