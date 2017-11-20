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
    
    public class MedioPago
    {

        public static void LlenarComboBox(ComboBox comboBox)
        {
            Dictionary<int, string> valoresCombo = new Dictionary<int, string>();
            DataTable medios = ConexionDB.SeleccionRegistros("SELECT id,nombre FROM SQL_86.medios_pagos ORDER BY nombre");
            foreach (DataRow medio in medios.Rows)
            {
                valoresCombo.Add(Convert.ToInt32(medio["id"].ToString()), medio["nombre"].ToString());
            }
            comboBox.DisplayMember = "Value";
            comboBox.ValueMember = "Key";
            comboBox.DataSource = valoresCombo.ToArray();
        }

    }

}
