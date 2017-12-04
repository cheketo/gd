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

        public void CambiarEstado(string estado)
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.facturas SET estado='"+estado+"' WHERE id="+Id);
        }

        public void Modificar()
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.roles SET " +
                "numero='"+Numero+"'" +
                " WHERE id=" + Id);
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

        public bool Validar(DataGridView items, Decimal importe )
        {

            return items.RowCount > 1 && importe > 0;
        }

    }
}
