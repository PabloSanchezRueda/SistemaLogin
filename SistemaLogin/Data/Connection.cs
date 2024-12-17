using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaLogin.Data
{
    internal class Connection
    {
        public static string server = "127.0.0.1";
        public static string dataBase = "login";
        public static string user = "root";
        public static string psw = "23344Ps30@@";

        public static MySqlConnection connMaster = new MySqlConnection();

        public static void openConnection()
        {

            string connectionString = $"server={server};database={dataBase};user={user};password={psw};";

            try
            {
                connMaster = new MySqlConnection(connectionString);

                connMaster.Open();
            }
            catch (Exception ex)
            {
            }

            if (connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexion establecida");
            } else
            {
                MessageBox.Show("Conexion no establecida");
            }
        }

        public static void closeConnnection()
        {

        }


    }
}
