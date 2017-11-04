using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace PagoAgilFrba
{
    public class Usuario
    {
        private int Id { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public int Intentos { get; set; }
        public string Estado { get; set; }
        public int IdSucursal { get; set; }
        public int IdRol { get; set; }
        public string NombreRol { get; set; }
        public string EstadoRol { get; set; }
        public DataTable Roles { get; set; }
        public DataTable Funcionalidades { get; set; }

        public Usuario(int id = 0)
        {
            this.Id = id;
        }

        public Boolean ObtenerDatosDB(string query)
        {
            DataTable data = ConexionDB.SeleccionRegistros(query);
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
            if(this.Existe() && this.EstaActivo())
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

        public Boolean EstaActivo()
        {
            return this.Estado == "A";
        }

        public DataTable ObtenerRoles()
        {
            if (Roles == null)
            {
                string query =
                "SELECT a.* FROM SQL_86.roles a " +
                "JOIN SQL_86.rel_roles_usuarios b ON (b.id_rol = a.id)" +
                "WHERE b.id_usuario = " + Id;
                Roles = ConexionDB.SeleccionRegistros(query);
                
                if(CantidadRoles()==1)
                {
                    DeterminarRol(Convert.ToInt32(Roles.Rows[0][0]));
                }
            }
            return Roles;
        }

        public void DeterminarRol(int idrol)
        {
            foreach (DataRow row in this.Roles.Rows)
            {
                if(idrol == Convert.ToInt32(row[0]))
                {
                    this.IdRol = Convert.ToInt32(row[0]);
                    this.NombreRol = row[1].ToString();
                    this.EstadoRol = row[2].ToString();
                    this.ObtenerFuncionalidades();
                }
            }
        }

        public DataTable ObtenerFuncionalidades()
        {
            if (this.IdRol > 0)
            {
                if (this.Funcionalidades == null)
                {
                    string query =
                    "SELECT * FROM SQL_86.funcionalidades a " +
                    "JOIN SQL_86.rel_roles_funcionalidades b ON (b.id_funcionalidad = a.id)" +
                    "WHERE b.id_rol = " + this.IdRol;
                    this.Funcionalidades = ConexionDB.SeleccionRegistros(query);
                }
            }
            return this.Funcionalidades;
        }

        public int CantidadRoles()
        {
            if(this.Roles==null)
            {
                this.ObtenerRoles();
            }
            return this.Roles.Rows.Count;
        }
        
    }
}
