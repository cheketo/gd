using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public class Rendicion
    {
        public int Id { set; get; }
        public int IdEmpresa { set; get; }
        public int IdMedio { set; get; }
        public Int64 Numero { set; get; }
        public Decimal Importe { set; get; }
        public string Fecha { set; get; }
        public string Estado { set; get; }
        public string Motivo { set; get; }
        public DataTable Facturas { set; get; }
        public DataGridView FacturasAPagar { set; get; }


        public Rendicion(int id = 0)
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
            return this.ObtenerDatosDB("SELECT * FROM SQL_86.pagos WHERE id = " + this.Id.ToString());
        }

        public Boolean ObtenerDatosDB(string query)
        {
            DataTable data = ConexionDB.SeleccionRegistros(query);
            if (data.Rows.Count > 0)
            {
                this.Id = Convert.ToInt32(data.Rows[0][0].ToString());
                this.Fecha = data.Rows[0][2].ToString();
                this.Importe = Convert.ToDecimal(data.Rows[0][1].ToString());
                this.IdEmpresa = Convert.ToInt32(data.Rows[0][5].ToString());
                this.IdMedio = Convert.ToInt32(data.Rows[0][4].ToString());
                this.Estado = data.Rows[0][3].ToString();
                this.Motivo = data.Rows[0][4].ToString();
                this.Facturas = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.facturas WHERE id_pago = "+this.Id.ToString());
                return true;
            }
            else
            {
                return false;
            }
        }

        public void LlenarDataGridView(DataGridView listado)
        {
            this.Facturas = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.vw_listado_facturas WHERE fecha_vencimiento >= DATEADD(d,DATEDIFF(d,0,GETDATE()),0) AND (estado='P' OR estado='D') AND id_cliente = " + this.IdEmpresa.ToString());
            listado.Rows.Clear();
            int indice = 0;
            foreach (DataRow row in this.Facturas.Rows)
            {
                listado.Rows.Add();
                listado.Rows[indice].Cells["Id"].Value = row[0].ToString();
                listado.Rows[indice].Cells["IdEmpresa"].Value = row[5].ToString();
                listado.Rows[indice].Cells["IdEmpresa"].Value = row[6].ToString();
                listado.Rows[indice].Cells["Numero"].Value = row[1].ToString();
                listado.Rows[indice].Cells["Importe"].Value = row[3].ToString();
                listado.Rows[indice].Cells["ImporteTexto"].Value = "$ "+row[3].ToString();
                listado.Rows[indice].Cells["Vencimiento"].Value = row[4].ToString();
                listado.Rows[indice].Cells["NombreEmpresa"].Value = row[12].ToString();
                listado.Rows[indice].Cells["NombreCliente"].Value = row[13].ToString();
                indice++;
            }
        }

        public void CambiarEstado(string estado)
        {
            ConexionDB.ModificarRegistros("UPDATE SQL_86.pago SET estado='"+estado+"' WHERE id="+Id);
        }

        public void Guardar()
        {
            ConexionDB.ModificarRegistros("INSERT INTO SQL_86.pagos " +
                "(fecha,importe,id_cliente,id_medio,estado)VALUES(" +
                 "'"+Fecha+"'" +
                 ","+Importe+
                 "," + IdEmpresa +
                 "," + IdMedio +
                ",'P')");
            ObtenerDatosDB("SELECT * FROM SQL_86.pagos WHERE fecha='" + Fecha + "' AND id_cliente="+IdEmpresa+" AND id_medio="+IdMedio+" ORDER BY id DESC");
            AsociarFacturas();
        }

        public void AsociarFacturas()
        {
            if (this.FacturasAPagar.RowCount > 0)
            {
                List<string> registros = new List<string>();
                foreach (DataGridViewRow row in this.FacturasAPagar.Rows)
                {
                    if(row.Cells["Id"].Value !=null && row.Cells["Seleccionar"].Value != null && row.Cells["Seleccionar"].Value.ToString() == "1")
                        registros.Add(row.Cells["Id"].Value.ToString());
                }
                string query = "UPDATE SQL_86.facturas SET id_pago = "+this.Id + ", estado='A' WHERE id IN (" + String.Join(", ", registros.ToArray())+")";
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
