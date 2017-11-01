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
        static SqlConnection conexion = null;
        //SqlCommand cmd = new SqlCommand();
        //SqlDataReader reader;


        public static SqlConnection getInstanciaConexionDB()
        {
            if(conexion == null) {

                conexion = new SqlConnection(rutaConexion);

            }

            return conexion;
        }
       
          
        public static DataSet SeleccionRegistros(DataSet dataSet, string queryString)
        {
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = new SqlCommand(queryString, ConexionDB.getInstanciaConexionDB());
            adaptador.Fill(dataSet);
            return dataSet;

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

        //public static ExisteRegistro()

    }
}
