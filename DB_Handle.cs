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
        static string conn = @"Data Source=|DataDirectory|lfi.db";

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
            try
            {
                SQLiteConnection cnn = new SQLiteConnection(conn);
                cnn.Open();
                SQLiteCommand mycommand = new SQLiteCommand(cnn);
                mycommand.CommandText = sql;
                SQLiteDataReader reader = mycommand.ExecuteReader();
                reader.Close();
                cnn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }


}
