using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Importador_de_Etiquetas.DAL
{
    public class MySQL
    {
        private MySqlConnection Connection;
        private MySqlCommand Command;
        private MySqlDataAdapter Adapter;

        public MySQL()
        {
            Connection = new MySqlConnection();
            Command = new MySqlCommand();
            Adapter = new MySqlDataAdapter();
        }

        public List<string> ObtenerBasesDeDatos()
        {
            List<string> lstDatabases = new List<string>();

            Connection.ConnectionString = ObtenerConnectionString();
            try
            {
                Connection.Open();
                Command.CommandText = "SHOW DATABASES";
                Command.Connection = Connection;

                DataTable dt = new DataTable();
                Adapter.SelectCommand = Command;
                Adapter.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    lstDatabases.Add(Convert.ToString(row[0]));
                }

                Connection.Close();
            }
            catch
            {
                if (Connection.State != ConnectionState.Closed)
                    Connection.Close();
            }

            return lstDatabases;
        }

        private string ObtenerConnectionString()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = Properties.Settings.Default.Server;
            sb.UserID = Properties.Settings.Default.User;
            sb.Password = Properties.Settings.Default.Pass;
            sb.Port = Convert.ToUInt32(Properties.Settings.Default.Port);

            return sb.ToString();
        }
    }
}
