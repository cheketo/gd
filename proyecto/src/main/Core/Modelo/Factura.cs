using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public class Factura
    {
        public int Id { set; get; }
        public int IdEmpresa { set; get; }
        public int IdCliente { set; get; }
        public int IdSucursal { set; get; }
        public int IdRendicion { set; get; }
        public int IdPago { set; get; }
        public Int64 Numero { set; get; }
        public Decimal Importe { set; get; }
        public string Fecha { set; get; }
        public string FechaVencimiento { set; get; }
        public string Estado { set; get; }
        public DataTable Items { set; get; }
        public DataGridView ItemsNuevos { set; get; }


        public Factura(int id = 0)
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
            return this.ObtenerDatosDB("SELECT * FROM SQL_86.facturas WHERE id = " + this.Id.ToString());
        }

        public Boolean ObtenerDatosDB(string query)
        {
            DataTable data = ConexionDB.SeleccionRegistros(query);
            if (data.Rows.Count > 0)
            {
                this.Id = Convert.ToInt32(data.Rows[0][0].ToString());
                this.Numero = Convert.ToInt64(data.Rows[0][1].ToString());
                this.Fecha = data.Rows[0][2].ToString();
                this.Importe = Convert.ToDecimal(data.Rows[0][3].ToString());
                this.FechaVencimiento = data.Rows[0][4].ToString();
                this.IdEmpresa = Convert.ToInt32(data.Rows[0][5].ToString());
                this.IdCliente = Convert.ToInt32(data.Rows[0][6].ToString());
                this.Estado = data.Rows[0][7].ToString();
                this.IdSucursal = Convert.ToInt32(data.Rows[0][8].ToString());
                if(int.TryParse(data.Rows[0][9].ToString(), out var result))
                    this.IdRendicion = Convert.ToInt32(data.Rows[0][9].ToString());
                if (int.TryParse(data.Rows[0][10].ToString(), out var result2))
                    this.IdPago = Convert.ToInt32(data.Rows[0][10].ToString());
                this.Items = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.facturas_items WHERE id_factura = "+this.Id.ToString());
                return true;
            }
            else
            {
                return false;
            }
        }


        /*public void ObtenerListado(DataGridView result ,string where = "",string campos = "*",bool edit = true,bool delete=true,bool activate=false)
        {
            //result.Columns.Clear();
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
        }*/

        public void CambiarEstado(string estado)
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.facturas SET estado='"+estado+"' WHERE id="+Id);
        }

        public void Modificar()
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.roles SET " +
                "numero='"+Numero+"'" +
                " WHERE id=" + Id);
            //EliminarRelacionesFuncionalidades();
            //InsertarRelacionesFuncionalidades();
        }

        public void Guardar()
        {
            ConexionDB.ModificarRegistros("INSERT INTO SQL_86.facturas " +
                "(numero,fecha,importe,fecha_vencimiento,id_empresa,id_cliente,id_sucursal,estado)VALUES(" +
                 Numero +
                 ",'"+Fecha+"'" +
                 ","+Importe+
                 ",'"+FechaVencimiento+"'"+
                 ","+IdEmpresa+
                 "," + IdCliente +
                 "," + IdSucursal +
                ",'P')");
            ObtenerDatosDB("SELECT * FROM SQL_86.facturas WHERE numero='" + Numero + "' AND id_cliente="+IdCliente+" AND id_empresa="+IdEmpresa);
            InsertarItems();
        }

        public void InsertarItems()
        {
            if (this.ItemsNuevos.RowCount > 0)
            {
                List<string> registros = new List<string>();
                foreach (DataGridViewRow row in this.ItemsNuevos.Rows)
                {
                    if(row.Cells["Monto"].Value !=null)
                        registros.Add("("+this.Id+","+ row.Cells["Monto"].Value.ToString() + ", " + row.Cells["Cantidad"].Value.ToString() + ")");
                }
                string query = "INSERT INTO SQL_86.facturas_items (id_factura,monto,cantidad)VALUES" + String.Join(", ", registros.ToArray());
                ConexionDB.ModificarRegistros(query);
            }
        }
        /*
        public void EliminarRelacionesFuncionalidades()
        {
            ConexionDB.ModificarRegistros("DELETE FROM SQL_86.rel_roles_funcionalidades WHERE id_rol="+Id.ToString());
        }*/

        public bool Validar(DataGridView items, Decimal importe )
        {

            return items.RowCount > 1 && importe > 0;
        }

        /*public static void CargarComboEstado(ComboBox comboBox)
        {
            Dictionary<int, string> valoresCombo = new Dictionary<int, string>();
            valoresCombo.Add(1, "Activo");
            valoresCombo.Add(2, "Inactivo");
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.DataSource = valoresCombo.ToArray();
        }*/

        /*public static void CargarFuncionalidades(CheckedListBox lista,Factura rol=null)
        {
            DataTable funcionalidades = Factura.ObtenerFuncionalidades();
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
        }*/

    }
}
