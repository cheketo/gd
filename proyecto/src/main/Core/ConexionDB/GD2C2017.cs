using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace PagoAgilFrba
{
    public class GD2C2017 : DataContext
    {
        const string RUTA_CONEXION = "Data Source=.\\SQLSERVER2012;Initial Catalog=GD2C2017;Persist Security Info=True;User ID=gd;Password=gd2017";
        public Table<Cliente> Clientes;
        private static GD2C2017 instancia;

        private GD2C2017() : base(RUTA_CONEXION) { }

        public static GD2C2017 Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GD2C2017();
                }

                return instancia;
            }
        }
    }
}
