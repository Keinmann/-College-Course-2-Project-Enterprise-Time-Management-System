using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace ИС_Учёт_времени
{
    class DB
    {
        
        MySqlConnection connection;
        private string cmd;
        public bool checkConnection() 
        {
            bool flag = true;
            try { connection.Open(); }
            catch 
            { flag = false; }
            finally 
            {
                connection.Close();
            } 
            return flag;
        }
        public void SetPreferences(string path)
        {
            cmd = File.ReadAllText(path);
            connection = new MySqlConnection(cmd);
        }

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed) { connection.Open(); }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open) { connection.Close(); }
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void End() { connection.Dispose(); }

    }
}
