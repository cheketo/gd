using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Core.Helpers;

namespace PagoAgilFrba
{
    public partial class AltaRendicion : Form
    {
        public Rendicion obj;
        public Usuario usuario;

        public AltaRendicion(Usuario usuario)
        {
            this.usuario = usuario;
            obj = new Rendicion();
            InitializeComponent();
            Empresa.LlenarComboBox(comboBoxEmpresa);
            if (usuario.TempId > 0)
                comboBoxEmpresa.SelectedValue = usuario.TempId;
        }

        private void AltaRendicion_Load(object sender, EventArgs e)
        {
            
        }

        public void BuscarFacturas()
        {
            if (comboBoxEmpresa.SelectedValue != null)
            {
                obj.IdEmpresa = Convert.ToInt32(comboBoxEmpresa.SelectedValue.ToString());
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //if ()
            //{
                if (MensajeHelper.MostrarConfirmacion("¿Desea realizar la rendición mensual para la empresa "+comboBoxEmpresa.SelectedText+"?", "Confirmación - Rendicion Agil FRBA App") == DialogResult.Yes)
                {
                    obj.Fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    obj.IdEmpresa = Convert.ToInt32(comboBoxEmpresa.SelectedValue.ToString());
                    obj.Importe = Convert.ToDecimal(labelTotal.Text);
                    obj.Guardar();
                    this.Dispose();
                }
            /*}else{
                MensajeHelper.MostrarError("Seleccione al menos una factura para pagar.", "Error");
            }*/

        }        

        public void CalcularImporte()
        {
            decimal importe = 0;
            /*foreach (DataGridViewRow row in dataGridViewFacturas.Rows)
            {
                if (row.Cells["Seleccionar"].Value != null && row.Cells["Seleccionar"].Value.ToString() == "1")
                {

                    importe = importe + Convert.ToDecimal(row.Cells["Importe"].FormattedValue.ToString());
                }
            }*/
            labelTotal.Text = importe.ToString();
        }

        private void comboBoxCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            BuscarFacturas();
            CalcularImporte();
        }
    }
}
