using launcher_minecraft.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

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

    }
}
