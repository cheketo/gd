using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagoAgilFrba.Core.ConexionDB;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Windows.Forms;
using System.Data.Linq.SqlClient;

namespace PagoAgilFrba
{
    [Table(Name = "SQL_86.clientes")]
    public class Cliente
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)] public int Id { get; set; }
        [Column] public string Dni { get; set; }
        [Column] public string Apellido { get; set; }
        [Column] public string Nombre { get; set; }
        [Column(Name="fecha_nacimiento")] public DateTime FechaNacimiento { get; set; }
        [Column] public string Mail { get; set; }
        [Column] public string Direccion { get; set; }
        [Column] public string CP { get; set; }
        [Column] public string Piso { get; set; }
        [Column] public string Depto { get; set; }
        [Column] public string Telefono { get; set; }
        [Column] public string Localidad { get; set; }
        [Column] public char Estado { get; set; }

        public Cliente FindOneByID(int id)
        {

            GD2C2017 cDB = GD2C2017.Instancia;
            var cliente = (from registros in cDB.Clientes
                           where registros.Id == id
                           select registros).FirstOrDefault();
            return cliente;
        }

        public List<Cliente> FindByParametersLike(string dni = null, string apellido = null, string nombre = null)
        {
            if(dni != "")
            {
                GD2C2017 cDB = GD2C2017.Instancia;
                var clientes = (from registros in cDB.Clientes
                                where registros.Nombre.Contains(nombre) &&
                                    registros.Apellido.Contains(apellido) &&
                                    registros.Dni == dni
                                select registros);
                return clientes.ToList();

            } else
            {
                GD2C2017 cDB = GD2C2017.Instancia;
                var clientes = (from registros in cDB.Clientes
                                where registros.Nombre.Contains(nombre) &&
                                    registros.Apellido.Contains(apellido)
                                select registros);
                return clientes.ToList();
            }
        }

        public void Save()
        {
            if(Id == 0)
            {
                GD2C2017.Instancia.Clientes.InsertOnSubmit(this);
                GD2C2017.Instancia.SubmitChanges();
            } else {
                GD2C2017.Instancia.SubmitChanges();
            }
              
        }

        public static void LlenarComboBox(ComboBox comboBox)
        {
            Dictionary<int, string> valoresCombo = new Dictionary<int, string>();
            DataTable clientes = ConexionDB.SeleccionRegistros("SELECT id,CONCAT(apellido,', ',nombre) as nombre FROM SQL_86.clientes ORDER BY apellido,nombre");
            foreach (DataRow cliente in clientes.Rows)
            {
                valoresCombo.Add(Convert.ToInt32(cliente["id"].ToString()), cliente["nombre"].ToString());
            }
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.DataSource = valoresCombo.ToArray();
        }

    }

}
