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
        static string conn = @"PRAGMA foreign_keys = ON;
            Data Source=" + Folder_IO.GetUserDataPath();
        static SQLiteConnection manual_cnn;
        static bool IsOpen = false;

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
