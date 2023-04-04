using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HOTEL.Dao
{
    internal class Data
    {
        public MySqlConnection Conectar()
        {
            string servidor = "localhost";
            string usuario = "root";
            string password = "";
            string baseDeDatos = "Hotel 1.0";

            string cadenaConexion = "Database=" + baseDeDatos + "; Data Source=" + servidor + "; User id=" + usuario + ";Password=" + password + "";

            MySqlConnection conexionDb = new MySqlConnection(cadenaConexion);
            conexionDb.Open();
            return conexionDb;


        }
        public List<Client> listadodeHuespedes()
        {
            List<Client> lista = new List<Client>();


            string consulta = "SELECT * FROM `hotel`";

            MySqlCommand comando = new MySqlCommand(consulta);
            comando.Connection = Conectar();
            MySqlDataReader lectura = comando.ExecuteReader();



            while (lectura.Read())
            {
                
            }
         //5:34

            return lista;
        }
    }
}
