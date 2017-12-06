using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
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

        public void CargarOpcionesSelectorAnio()
        {
            List<int> opcionesSelectorAnio = new List<int>();
            int actualAnio = DateTime.Now.Year;

            for (int i = actualAnio; i >= actualAnio - 50; i--)
            {
                opcionesSelectorAnio.Add(i);
            }

            cBAnio.DataSource = opcionesSelectorAnio.ToArray();
        }

        public void CargarOpcionesSelectorTrimestre()
        {
            Dictionary<string, int> opcionesSelectorTrimestre = new Dictionary<string, int>();
            opcionesSelectorTrimestre.Add("1er Trimestre", 1);
            opcionesSelectorTrimestre.Add("2do Trimestre", 2);
            opcionesSelectorTrimestre.Add("3er Trimestre", 3);
            opcionesSelectorTrimestre.Add("4to Trimestre", 4);

            cBTrimestre.DisplayMember = "Key";
            cBTrimestre.ValueMember = "Value";

            cBTrimestre.DataSource = opcionesSelectorTrimestre.ToArray();
        }

        public void CargarOpcionesSelectorReportes()
        {
            Dictionary<string, int> opcionesSelectorReportes = new Dictionary<string, int>();
            opcionesSelectorReportes.Add("Porcentaje de facturas cobradas por empresa", 1);
            opcionesSelectorReportes.Add("Empresas con mayor monto rendido", 2);
            opcionesSelectorReportes.Add("Clientes con mas pagos", 3);
            opcionesSelectorReportes.Add("Clientes con mayor porcentaje de facturas pagadas", 4);

            cBReporte.DisplayMember = "Key";
            cBReporte.ValueMember = "Value";

            cBReporte.DataSource = opcionesSelectorReportes.ToArray();
        }

        public void buttonVerReporte_Click(object sender, EventArgs e)
        {
            Estadisticas estadistica = new Estadisticas();
            int anio = (int)cBAnio.SelectedValue;
            int trimestre = (int)cBTrimestre.SelectedValue;
            int reporte = (int)cBReporte.SelectedValue;

            try
            {
                DataTable dataTable = estadistica.consultar_estadisticas(anio, trimestre, reporte);

                if (dataTable.Rows.Count != 0)
                    dGVReporte.DataSource = dataTable;
                else
                {
                    dGVReporte.DataSource = new DataTable();
                    MessageBox.Show("No hay registros para la fecha ingresada.", "Listado Estadistico", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error en Listado Estadisco", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
