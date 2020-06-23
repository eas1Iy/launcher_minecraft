using launcher_minecraft.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace launcher_minecraft._class
{
    class dataBase
    {
        static OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public static string ConnectionString = Settings.Default["DataBase"].ToString();

        static dataBase()
        {
            connection = new OleDbConnection(ConnectionString);
        }

        public DataTable usersFill()
        {
            bufferTable = new DataTable();
            connection.Close();
            try
            {
                connection.Open();
                dataAdapter = new OleDbDataAdapter("SELECT * FROM users ORDER BY user_id", connection);
                bufferTable.Clear();
                dataAdapter.Fill(bufferTable);
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
            return bufferTable;

        }

        public void userAdd(string ник,string пароль,string статус)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand($"INSERT INTO users ([никнейм],[пароль],[админ]) VALUES (?,?,?)", connection);
                command.Parameters.AddWithValue("[никнейм]", ник);
                command.Parameters.AddWithValue("[пароль]", пароль);
                command.Parameters.AddWithValue("[админ]", статус);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

        public void DeleteFromTable(string table, string kod, int ID)
        {
            try
            {
                connection.Open();
                command = new OleDbCommand($"DELETE FROM {table} WHERE [{kod}] = {ID}", connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                connection.Close();
            }
        }

    }
}
