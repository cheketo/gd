using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public class Sucursal
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Direccion { set; get; }
        public string Estado { set; get; }
        public string Cp { set; get; }

        public Sucursal(int id = 0)
        {
            SetId(id);
            if (id>0)
            {
                SetDatos();
            }
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public Boolean SetDatos()
        {
            return this.ObtenerDatosDB("SELECT * FROM SQL_86.sucursales WHERE id = " + this.Id);
        }

        public Boolean ObtenerDatosDB(string query)
        {
            DataTable data = ConexionDB.SeleccionRegistros(query);
            if (data.Rows.Count > 0)
            {
                this.Id = Convert.ToInt32(data.Rows[0][0].ToString());
                this.Estado = data.Rows[0][1].ToString();
                this.Nombre = data.Rows[0][2].ToString();
                this.Direccion = data.Rows[0][3].ToString();
                this.Cp = data.Rows[0][4].ToString();
                return true;
            }
            else
            {
                return false;
            }
        }


        public void ObtenerListado(DataGridView result ,string where = "",string campos = "*",bool edit = true,bool delete=true,bool activate=false)
        {
            result.DataSource = null;
            result.ColumnCount = 0;
            //Columna Boton Inactivar
            DataGridViewButtonColumn colBorrar = new DataGridViewButtonColumn();
            {
                colBorrar.HeaderText = "";
                colBorrar.Text = "Inactivar";
                colBorrar.UseColumnTextForButtonValue = true;
                colBorrar.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
                colBorrar.FlatStyle = FlatStyle.Standard;
                colBorrar.DisplayIndex = result.ColumnCount;
                colBorrar.Visible = delete;
            }
            result.Columns.Add(colBorrar);

            //Columna Boton Activar
            DataGridViewButtonColumn colActivar = new DataGridViewButtonColumn();
            {
                colActivar.HeaderText = "";
                colActivar.Text = "Activar";
                colActivar.UseColumnTextForButtonValue = true;
                colActivar.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
                colActivar.FlatStyle = FlatStyle.Standard;
                colActivar.DisplayIndex = result.ColumnCount;
                colActivar.Visible = activate;
            }
            result.Columns.Add(colActivar);

            //Columna Boton Editar
            DataGridViewButtonColumn colEditar = new DataGridViewButtonColumn();
            {
                colEditar.HeaderText = "";
                colEditar.Text = "Editar";
                colEditar.Tag = Id;
                colEditar.UseColumnTextForButtonValue = true;
                colEditar.AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
                colEditar.FlatStyle = FlatStyle.Standard;
                colEditar.DisplayIndex = result.ColumnCount;
                colEditar.Visible = edit;
            }
            result.Columns.Add(colEditar);

            string query = "SELECT " + campos + " FROM SQL_86.vw_listado_sucursales WHERE 1=1 " + where;
            result.DataSource = ConexionDB.SeleccionRegistros(query);
        }

        public void CambiarEstado(string estado)
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.sucursales SET estado='"+estado+"' WHERE id="+Id);
        }

        public void Modificar()
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.sucursales SET " +
                "nombre='"+Nombre+"'" +
                ",direccion='"+Direccion+"'" +
                ",cp='" + Cp +"'"+
                ",estado='" + Estado + "'" +
                " WHERE id=" + Id);
        }

        public void Guardar()
        {
            ConexionDB.ModificarRegistros("INSERT INTO SQL_86.sucursales " +
                "(nombre,direccion,cp,estado)VALUES(" +
                "'" + Nombre + "'" +
                ",'" + Direccion + "'" +
                ",'" + Cp + "'" +
                ",'" + Estado + "')");
        }

        public bool Validar(string cp, int id =0 )
        {
            Boolean result = true;
            if (cp != "")
            {
                DataTable data = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.sucursales WHERE cp='" + cp + "' AND id!="+id);
                if (data.Rows.Count > 0)
                    return false;
            }
            return result;
        }

        public static void CargarComboEstado(ComboBox comboBox)
        {
            Dictionary<int, string> valoresCombo = new Dictionary<int, string>();
            valoresCombo.Add(1, "Activo");
            valoresCombo.Add(2, "Inactivo");
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.DataSource = valoresCombo.ToArray();
        }

    }
}
