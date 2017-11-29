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
    public partial class AltaPago : Form
    {
        public Pago obj;
        public Usuario usuario;

        public AltaPago(Usuario usuario)
        {
            this.usuario = usuario;
            obj = new Pago();
            InitializeComponent();
            Cliente.LlenarComboBox(comboBoxCliente);
            MedioPago.LlenarComboBox(comboBoxMedio);
            if (usuario.TempId > 0)
                comboBoxCliente.SelectedValue = usuario.TempId;
        }

        private void AltaPago_Load(object sender, EventArgs e)
        {
            
        }

        public void BuscarFacturas()
        {
            if (comboBoxCliente.SelectedValue != null)
            {
                obj.IdCliente = Convert.ToInt32(comboBoxCliente.SelectedValue.ToString());
                obj.LlenarDataGridView(dataGridViewFacturas);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarGrid())
            {
                if (MensajeHelper.MostrarConfirmacion("¿Desea pagar las facturas seleccionadas?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                {
                    obj.Fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    obj.IdCliente = Convert.ToInt32(comboBoxCliente.SelectedValue.ToString());
                    obj.IdMedio = Convert.ToInt32(comboBoxMedio.SelectedValue.ToString());
                    obj.Importe = Convert.ToDecimal(labelImporte.Text);
                    obj.FacturasAPagar = dataGridViewFacturas;
                    obj.Guardar();
                    this.Dispose();
                }
            }else{
                MensajeHelper.MostrarError("Seleccione al menos una factura para pagar.", "Error");
            }

        }

        public bool ValidarGrid()
        {
            bool validado = false;
            foreach(DataGridViewRow row in dataGridViewFacturas.Rows)
            {
                if (row.Cells["Seleccionar"].Value != null && row.Cells["Seleccionar"].Value.ToString() == "1")
                    validado = true;
            }
            return validado;
            
        }

        public void CalcularImporte()
        {
            decimal importe = 0;
            foreach (DataGridViewRow row in dataGridViewFacturas.Rows)
            {
                if (row.Cells["Seleccionar"].Value != null && row.Cells["Seleccionar"].Value.ToString() == "1")
                {

                    importe = importe + Convert.ToDecimal(row.Cells["Importe"].FormattedValue.ToString());
                }
            }
            labelImporte.Text = importe.ToString();
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewFacturas.CommitEdit(DataGridViewDataErrorContexts.Commit);
            CalcularImporte();
        }

        private void comboBoxCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            BuscarFacturas();
            CalcularImporte();
        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
