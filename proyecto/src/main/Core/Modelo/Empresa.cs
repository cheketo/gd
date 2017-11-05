using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public class Empresa
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Cuit { set; get; }
        public string Direccion { set; get; }
        public int IdRubro { set; get; }
        public string Estado { set; get; }
        public decimal Porcentaje { set; get; }

        public Empresa(int id = 0)
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
            return this.ObtenerDatosDB("SELECT * FROM SQL_86.empresas WHERE id = " + this.Id);
        }

        public Boolean ObtenerDatosDB(string query)
        {
            DataTable data = ConexionDB.SeleccionRegistros(query);
            if (data.Rows.Count > 0)
            {
                this.Id = Convert.ToInt32(data.Rows[0][0].ToString());
                this.Nombre = data.Rows[0][1].ToString();
                this.Cuit = data.Rows[0][2].ToString();
                this.Direccion = data.Rows[0][3].ToString();
                this.IdRubro = Convert.ToInt32(data.Rows[0][4].ToString());
                this.Estado = data.Rows[0][5].ToString();
                this.Porcentaje = Convert.ToDecimal(data.Rows[0][6].ToString());

                return true;
            }
            else
            {
                return false;
            }
        }


        public void ObtenerListado(DataGridView result ,string where = "",string campos = "*",bool edit = true,bool delete=true)
        {
            result.Columns.Clear();
            if (edit)
            {
                DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
                {
                    buttons.HeaderText = "";
                    buttons.Text = "Editar";
                    buttons.Tag = Id;
                    buttons.UseColumnTextForButtonValue = true;
                    buttons.AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.AllCells;
                    buttons.FlatStyle = FlatStyle.Standard;
                    buttons.DisplayIndex = result.ColumnCount;
                }
                result.Columns.Add(buttons);
            }

            if (delete)
            {
                DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
                {
                    buttons.HeaderText = "";
                    buttons.Text = "Eliminar";
                    buttons.UseColumnTextForButtonValue = true;
                    buttons.AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.AllCells;
                    buttons.FlatStyle = FlatStyle.Standard;
                    buttons.DisplayIndex = result.ColumnCount;
                }
                result.Columns.Add(buttons);
            }
            string query = "SELECT "+campos+" FROM SQL_86.empresas WHERE estado='A' "+where;
            result.DataSource = ConexionDB.SeleccionRegistros(query);
        }

        public void Inhabilitar()
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.empresas SET estado='I' WHERE id="+Id);
        }

        public void Modificar()
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.empresas SET " +
                "nombre='"+Nombre+"'" +
                ",cuit='"+Cuit+"'" +
                ",direccion='"+Direccion+"'" +
                ",id_rubro=" + IdRubro +
                ",porcentaje_rendicion=" + Porcentaje +
                " WHERE id=" + Id);
        }

        public void Guardar()
        {
            ConexionDB.ModificarRegistros("INSERT INTO SQL_86.empresas " +
                "(nombre,cuit,direccion,id_rubro,estado,porcentaje_rendicion)VALUES(" +
                "'" + Nombre + "'" +
                ",'" + Cuit + "'" +
                ",'" + Direccion + "'" +
                "," + IdRubro +",'A',0)");
        }

        

        public bool ValidarEmpresa(string nombre,string cuit)
        {
            Boolean result = true;
            if (nombre != "" && cuit != "")
            {
                DataTable data = ConexionDB.SeleccionRegistros("SELECT TOP 1 * FROM SQL_86.empresas WHERE nombre='" + nombre + "' OR cuit ='" + cuit + "'");
                if (data.Rows.Count > 0)
                    return false;
            }
            return result;
        }

    }
}
