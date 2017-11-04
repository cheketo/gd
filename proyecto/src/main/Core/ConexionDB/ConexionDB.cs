using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace PagoAgilFrba
{
    class ConexionDB
    {
        const string rutaConexion = "Data Source=.\\SQLSERVER2012;Initial Catalog=GD2C2017;Persist Security Info=True;User ID=gd;Password=gd2017";
        static SqlConnection conexion = new SqlConnection(rutaConexion);

        /*
        public static SqlConnection getInstanciaConexionDB()
        {
            if(conexion == null) {

                conexion = new SqlConnection(rutaConexion);
                conexion.Open();

            }
            return conexion;
        }*/

        public static void Open()
        {
            conexion.Open();
        }

        public static void Close()
        {
            conexion.Close();
        }
          
        public static DataTable SeleccionRegistros(string queryString)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand(queryString, conexion);
            DataTable dataTable = new DataTable();
            adaptador.Fill(dataTable);
            return dataTable;
        }

        public static void ModificarRegistros(string query)
        {
            SqlCommand result = new SqlCommand(query, conexion);
            conexion.Open();
            SqlDataReader reader = result.ExecuteReader();
            reader.Read();
            conexion.Close();
        }

        public static string getHashSha256(string text)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(text);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
    }
}
