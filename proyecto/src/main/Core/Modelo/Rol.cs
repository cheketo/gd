using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public class Rol
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Estado { set; get; }
        public List<string> FuncionalidadesSeleccionadas { set; get; }
        public DataTable funcionalidades { set; get; }
        public CheckedListBox.CheckedItemCollection Items { set; get; }

        public Rol(int id = 0)
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
            return this.ObtenerDatosDB("SELECT * FROM SQL_86.roles WHERE id = " + this.Id.ToString());
        }

        public Boolean ObtenerDatosDB(string query)
        {
            DataTable data = ConexionDB.SeleccionRegistros(query);
            if (data.Rows.Count > 0)
            {
                this.Id = Convert.ToInt32(data.Rows[0][0].ToString());
                this.Estado = data.Rows[0][2].ToString();
                this.Nombre = data.Rows[0][1].ToString();
                this.funcionalidades = ConexionDB.SeleccionRegistros("SELECT a.* FROM SQL_86.funcionalidades a JOIN SQL_86.rel_roles_funcionalidades b ON (b.id_funcionalidad=a.id) WHERE id_rol = "+this.Id.ToString());
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
                colBorrar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                colActivar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                colEditar.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                colEditar.FlatStyle = FlatStyle.Standard;
                colEditar.DisplayIndex = result.ColumnCount;
                colEditar.Visible = edit;
            }
            result.Columns.Add(colEditar);

            result.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            string query = "SELECT " + campos + " FROM SQL_86.vw_listado_roles WHERE 1=1 " + where;
            result.DataSource = ConexionDB.SeleccionRegistros(query);
        }

        public void CambiarEstado(string estado)
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.roles SET estado='"+estado+"' WHERE id="+Id);
            if (estado == "I")
                ConexionDB.ModificarRegistros("DELETE FROM SQL_86.rel_roles_usuarios WHERE id_rol=" + Id);
        }

        public void Modificar()
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.roles SET " +
                "nombre='"+Nombre+"'" +
                " WHERE id=" + Id);
            EliminarRelacionesFuncionalidades();
            InsertarRelacionesFuncionalidades();
        }

        public void Guardar()
        {
            ConexionDB.ModificarRegistros("INSERT INTO SQL_86.roles " +
                "(nombre,estado)VALUES(" +
                "'" + Nombre + "'" +
                ",'A')");
            ObtenerDatosDB("SELECT * FROM SQL_86.roles WHERE nombre='" + Nombre + "'");
            InsertarRelacionesFuncionalidades();
        }

        public void InsertarRelacionesFuncionalidades()
        {
            if (FuncionalidadesSeleccionadas.Count > 0)
            {
                List<string> registros = new List<string>();

                foreach (string id in FuncionalidadesSeleccionadas)
                {
                    registros.Add("(" + Id.ToString() + ", " + id + ")");
                }

                string queryFuncionalidades = "INSERT INTO SQL_86.rel_roles_funcionalidades (id_rol,id_funcionalidad)VALUES" + String.Join(", ", registros.ToArray());
                ConexionDB.ModificarRegistros(queryFuncionalidades);
            }
        }

        public void EliminarRelacionesFuncionalidades()
        {
            ConexionDB.ModificarRegistros("DELETE FROM SQL_86.rel_roles_funcionalidades WHERE id_rol="+Id.ToString());
        }

        public bool Validar(string nombre, int id =0 )
        {
            Boolean result = true;
            if (nombre != "")
            {
                DataTable data = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.roles WHERE nombre='" + nombre + "' AND id!="+id);
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

        public static void CargarFuncionalidades(CheckedListBox lista,Rol rol=null)
        {
            DataTable funcionalidades = Rol.ObtenerFuncionalidades();
            foreach (DataRow row in funcionalidades.Rows)
            {
                lista.Items.Add(row["nombre"].ToString());
                if (rol.funcionalidades != null)
                {
                    int index = lista.Items.IndexOf(row["nombre"].ToString());
                    foreach(DataRow funcionalidad in rol.funcionalidades.Rows)
                    {
                        if(funcionalidad["nombre"].ToString() == row["nombre"].ToString())
                            lista.SetItemChecked(index, true);
                    }
                    
                }
            }
            
        }

        public static DataTable ObtenerFuncionalidades()
        {
            string query ="SELECT * FROM SQL_86.funcionalidades ";
            return ConexionDB.SeleccionRegistros(query);
        }

        public static List<string> ObtenerFuncionalidadesSeleccionadas(CheckedListBox lista)
        {
            List<string> seleccionadas = new List<string>();
            foreach (int indice in lista.CheckedIndices)
            {
                seleccionadas.Add("'"+lista.Items[indice].ToString()+"'");
            }
            List<string> ids = new List<string>();
            if (seleccionadas.Count>0)
            {
                string query = "SELECT * FROM SQL_86.funcionalidades WHERE nombre IN (" + String.Join(", ", seleccionadas.ToArray()) + ") ";
                DataTable funcionalidades = ConexionDB.SeleccionRegistros(query);
                foreach (DataRow funcionalidad in funcionalidades.Rows)
                {
                    ids.Add(funcionalidad["id"].ToString());
                }
            }
            return ids;
        }

    }
}
