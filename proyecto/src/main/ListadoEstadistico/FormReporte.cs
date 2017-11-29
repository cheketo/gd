using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class FormReporte : Form
    {
        public FormReporte()
        {
            InitializeComponent();
            CargarOpcionesSelectorAnio();
            CargarOpcionesSelectorTrimestre();
            CargarOpcionesSelectorReportes();
        }

        private void CargarOpcionesSelectorAnio()
        {
            List<int> opcionesSelectorAnio = new List<int>();
            int actualAnio = DateTime.Now.Year;

            for (int i = actualAnio; i >= actualAnio - 50; i--)
            {
                opcionesSelectorAnio.Add(i);
            }

            cBAnio.DataSource = opcionesSelectorAnio.ToArray();
        }

        private void CargarOpcionesSelectorTrimestre()
        {
            Dictionary<string, int> opcionesSelectorTrimestre = new Dictionary<string, int>();
            opcionesSelectorTrimestre.Add("1er Trimestre", 1);
            opcionesSelectorTrimestre.Add("2do Trimestre", 2);
            opcionesSelectorTrimestre.Add("3er Trimestre", 3);

            cBTrimestre.DisplayMember = "Key";
            cBTrimestre.ValueMember = "Value";

            cBTrimestre.DataSource = opcionesSelectorTrimestre.ToArray();
        }

        private void CargarOpcionesSelectorReportes()
        {
            Dictionary<string, string> opcionesSelectorReportes = new Dictionary<string, string>();
            opcionesSelectorReportes.Add("Porcentaje de facturas cobradas por empresa", "A");
            opcionesSelectorReportes.Add("Empresas con mayor monto rendido", "B");
            opcionesSelectorReportes.Add("Clientes con mas pagos", "C");
            opcionesSelectorReportes.Add("Clientes con mayor porcentaje de facturas pagadas", "C");

            cBReporte.DisplayMember = "Key";
            cBReporte.ValueMember = "Value";

            cBReporte.DataSource = opcionesSelectorReportes.ToArray();
        }

        private void cBAnio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
