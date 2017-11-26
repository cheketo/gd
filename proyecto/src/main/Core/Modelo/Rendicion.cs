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
        public Decimal Porcentaje { set; get; }
        public Decimal Comision { set; get; }
        public Decimal Importe { set; get; }
        public string Fecha { set; get; }
        public DataTable Facturas { set; get; }
        public DataTable FacturasARendir { set; get; }
        public DataRow Empresa { set; get; }


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
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SetEmpresa(int ID)
        {
            this.IdEmpresa = ID;
            DataTable empresa = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.empresas WHERE id = " + this.IdEmpresa.ToString());
            this.Empresa = empresa.Rows[0];
        }

        public void ObtenerFacturas()
        {
            this.FacturasARendir = ConexionDB.SeleccionRegistros("SELECT * FROM SQL_86.vw_listado_facturas WHERE estado='A' AND id_empresa = " + this.IdEmpresa.ToString());
        }

        public string ObtenerPorcentajeComision()
        {
            ObtenerComision(this.Empresa[6].ToString());
            return this.Porcentaje.ToString();
        }

        public string ObtenerComision(string porcentaje = "0")
        {
            if (decimal.TryParse(porcentaje, out var n) && porcentaje !="" && Convert.ToDouble(porcentaje)>0)
            {
                this.Porcentaje = Convert.ToDecimal(porcentaje);
                this.Comision = (this.Importe * this.Porcentaje) / 100;
                return this.Comision.ToString("#.##");
            }
            else
            {
                this.Porcentaje = 0;
                this.Comision = 0;
                return "0";
            }

        }

        public string ObtenerTotal()
        {
            decimal importe = 0;
            foreach (DataRow row in this.FacturasARendir.Rows)
            {
                importe = importe + Convert.ToDecimal(row[3].ToString());
            }
            this.Importe = importe;
            return this.Importe.ToString();
        }

        public bool ExisteRendicion()
        {
            int mes = DateTime.Now.Month;
            int anio = DateTime.Now.Year;
            string query = "SELECT * FROM SQL_86.rendiciones WHERE id_empresa="+this.IdEmpresa+" AND DATEPART(yyyy,fecha)=" + anio.ToString() + " AND DATEPART(mm,fecha) = " + mes.ToString();
            DataTable verificar = ConexionDB.SeleccionRegistros(query);
            return verificar.Rows.Count>0;
        }

        public void Guardar()
        {
            ConexionDB.ModificarRegistros("INSERT INTO SQL_86.rendiciones " +
                "(fecha,id_empresa,total,importe)VALUES(" +
                 "'"+Fecha+"'" +
                 "," + IdEmpresa +
                 "," +Importe+
                 "," + Comision +
                ")");
            ObtenerDatosDB("SELECT * FROM SQL_86.rendiciones WHERE fecha='" + Fecha + "' AND id_empresa="+IdEmpresa+" ORDER BY id DESC");
            AsociarFacturas();
            string query = "UPDATE SQL_86.empresas SET porcentaje_rendicion = "+Porcentaje+" WHERE id = " + this.IdEmpresa;
            ConexionDB.ModificarRegistros(query);
        }

        public void AsociarFacturas()
        {  
            string query = "UPDATE SQL_86.facturas SET estado = 'F', id_rendicion = "+this.Id + " WHERE estado = 'A' AND id_empresa="+this.IdEmpresa;
            ConexionDB.ModificarRegistros(query);
            
        }

        
    }
}
