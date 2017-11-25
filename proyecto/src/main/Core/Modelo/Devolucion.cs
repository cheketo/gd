using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public class Devolucion
    {
        public int Id { set; get; }
        public int IdCliente { set; get; }
        public Decimal Importe { set; get; }
        public string Fecha { set; get; }
        public string Motivo { set; get; }
        public DataTable Facturas { set; get; }
        public DataGridView FacturasADevolver { set; get; }


        public Devolucion(int id = 0)
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
            return this.ObtenerDatosDB("SELECT * FROM SQL_86.devoluciones WHERE id = " + this.Id.ToString());
        }

        public Boolean ObtenerDatosDB(string query)
        {
            DataTable data = ConexionDB.SeleccionRegistros(query);
            if (data.Rows.Count > 0)
            {
                this.Id = Convert.ToInt32(data.Rows[0][0].ToString());
                this.IdCliente = Convert.ToInt32(data.Rows[0][1].ToString());
                this.Importe = Convert.ToDecimal(data.Rows[0][2].ToString());
                this.Motivo = data.Rows[0][3].ToString();
                this.Fecha = data.Rows[0][4].ToString();
                this.Facturas = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.devoluciones_items WHERE id_devolucion = "+this.Id.ToString());
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LlenarDataGridView(DataGridView listado)
        {
            this.Facturas = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.vw_listado_facturas WHERE estado='A' AND id_cliente = " + this.IdCliente.ToString());
            listado.Rows.Clear();
            int indice = 0;
            foreach (DataRow row in this.Facturas.Rows)
            {
                listado.Rows.Add();
                listado.Rows[indice].Cells["Id"].Value = row[0].ToString();
                listado.Rows[indice].Cells["IdPago"].Value = row[10].ToString();
                listado.Rows[indice].Cells["IdCliente"].Value = row[6].ToString();
                listado.Rows[indice].Cells["Numero"].Value = row[1].ToString();
                listado.Rows[indice].Cells["Importe"].Value = row[3].ToString();
                listado.Rows[indice].Cells["ImporteTexto"].Value = "$ "+row[3].ToString();
                listado.Rows[indice].Cells["Vencimiento"].Value = row[4].ToString();
                listado.Rows[indice].Cells["NombreEmpresa"].Value = row[12].ToString();
                listado.Rows[indice].Cells["NombreCliente"].Value = row[13].ToString();
                indice++;
            }
        }

        /*public void CambiarEstado(string estado)
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.pago SET estado='"+estado+"' WHERE id="+Id);
        }*/

        public void Guardar()
        {
            ConexionDB.ModificarRegistros("INSERT INTO SQL_86.devoluciones " +
                "(fecha,importe,id_cliente,motivo)VALUES(" +
                 "'"+Fecha+"'" +
                 ","+Importe+
                 "," + IdCliente +
                 ",'" + Motivo + "'"+
                ")");
            ObtenerDatosDB("SELECT * FROM SQL_86.devoluciones WHERE fecha='" + Fecha + "' AND id_cliente="+IdCliente+" AND importe="+Importe+" ORDER BY id DESC");
            AsociarFacturas();
        }

        public void AsociarFacturas()
        {
            if (this.FacturasADevolver.RowCount > 0)
            {
                List<string> registros = new List<string>();
                foreach (DataGridViewRow row in this.FacturasADevolver.Rows)
                {
                    if (row.Cells["Id"].Value != null && row.Cells["Seleccionar"].Value != null && row.Cells["Seleccionar"].Value.ToString() == "1")
                    {
                        registros.Add("(" + this.Id + "," + row.Cells["Id"].Value.ToString() + "," + row.Cells["IdPago"].Value.ToString() + "," + row.Cells["Importe"].Value.ToString() + ")");   
                    }
                }
                string query = "INSERT INTO SQL_86.devoluciones_items (id_devolucion,id_factura,id_pago,importe)VALUES" + String.Join(", ", registros.ToArray());
                MessageBox.Show(query);
                ConexionDB.ModificarRegistros(query);
            }
        }
        
        /*
        public void EliminarRelacionesFuncionalidades()
        {
            ConexionDB.ModificarRegistros("DELETE FROM SQL_86.rel_roles_funcionalidades WHERE id_rol="+Id.ToString());
        }*/

        public bool Validar(DataGridView items )
        {
            return items.RowCount>1;
        }
    }
}
