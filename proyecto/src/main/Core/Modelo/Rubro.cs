using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public class Rubro
    {
        public int Id { set; get; }

        public Rubro(int id=0)
        {
            if(id>0)
            {
                   
            }
        }

        public void SetId(int id)
        {
            this.Id = id;
        }

        public DataTable ObtenerListado(string where = "", string campos = "*")
        {
            string query = "SELECT " + campos + " FROM SQL_86.rubros ";
            if (where != "")
            {
                query += "WHERE " + where;
            }
            return ConexionDB.SeleccionRegistros(query); ;
        }

        public static void CargarComboBox(ComboBox comboBox,string primeraOpcion = "")
        {
            Rubro rubro = new Rubro();
            Dictionary<int, string> valoresCombo = new Dictionary<int, string>();
            if(primeraOpcion!="")
                valoresCombo.Add(0, primeraOpcion);
            foreach (DataRow row in rubro.ObtenerListado().Rows)
            {
                valoresCombo.Add(Convert.ToInt32(row[0]), row[1].ToString());
            }
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.DataSource = valoresCombo.ToArray();
        }
    }
}
