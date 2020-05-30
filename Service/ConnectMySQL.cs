using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace WebApi.Service
{
    public class ConnectMySQL
    {
        private MySqlConnection _conn;
        private string _conectionString = "server=localhost;user=root;password=;database=test";

        public ConnectMySQL()
        {
            _conn = new MySqlConnection(_conectionString);
            _conn.Open();
        }

        public DataTable getData(string sqlCmd)
        {
            MySqlCommand cmd = new MySqlCommand(sqlCmd, _conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void executeQuery(string sqlCmd){
            MySqlCommand cmd = new MySqlCommand(sqlCmd, _conn);
            cmd.CommandText = sqlCmd;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = _conn;
            cmd.ExecuteNonQuery();
        }

    }
} 