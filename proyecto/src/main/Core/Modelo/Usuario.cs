using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PagoAgilFrba
{
    public class Usuario
    {
        private int Id { get; set; }
        string User { get; set; }
        string Password { get; set; }
        int Intentos { get; set; }
        string Estado { get; set; }
        int IdSucursal { get; set; }

        public Usuario(int id = 0)
        {
            this.Id = id;
        }

        public Boolean ObtenerDatosDB(string query)
        {
            DataTable data = ConexionDB.SeleccionRegistros(new DataTable(), query);
            if (data.Rows.Count > 0)
            {
                this.Id         = Convert.ToInt32(data.Rows[0][0]);
                this.User       = data.Rows[0][1].ToString();
                this.Password   = data.Rows[0][2].ToString();
                this.Intentos   = Convert.ToInt32(data.Rows[0][3]);
                this.Estado     = data.Rows[0][4].ToString();
                this.IdSucursal = Convert.ToInt32(data.Rows[0][5]);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean SetDatos()
        {
            return this.ObtenerDatosDB("select * from SQL_86.usuarios WHERE id = "+ this.Id);
        }

        public Boolean SetDatosPorUsuario(string usuario)
        {
            return this.ObtenerDatosDB("select * from SQL_86.usuarios WHERE usuario = '" + usuario+"'");
        }

        public Boolean ComprobarPassword(string hash)
        {
            return hash.ToUpper() == this.Password;
        }

        public void SumarIntento()
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.usuarios SET intentos = (intentos+1) WHERE id = " + this.Id);
        }

        public void ReiniciarIntentos()
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.usuarios SET intentos = 0 WHERE id = " + this.Id);
        }

        public Boolean Existe()
        {
            return this.Id > 0;
        }
        
    }
}
