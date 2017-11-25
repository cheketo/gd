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
    public partial class BajaPago : Form
    {
        public Devolucion obj;
        //public Usuario usuario;

        public BajaPago()
        {
            //this.usuario = usuario;
            obj = new Devolucion();
            InitializeComponent();
            Cliente.LlenarComboBox(comboBoxCliente);
            //if (usuario.TempId > 0)
                //comboBoxCliente.SelectedValue = usuario.TempId;
        }

        private void BajaPago_Load(object sender, EventArgs e)
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
            Boolean validaciones =
            ValidadorHelper.ValidarTextBox(textBoxMotivo);
            if (validaciones)
            {
                if (ValidarGrid())
                {
                    if (MensajeHelper.MostrarConfirmacion("¿Desea devolver las facturas seleccionadas?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                    {
                        obj.Fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        obj.IdCliente = Convert.ToInt32(comboBoxCliente.SelectedValue.ToString());
                        obj.Motivo = textBoxMotivo.Text;
                        obj.Importe = Convert.ToDecimal(labelImporte.Text);
                        obj.FacturasADevolver = dataGridViewFacturas;
                        obj.Guardar();
                        this.Dispose();
                    }
                }
                else
                {
                    MensajeHelper.MostrarError("Seleccione al menos una factura.", "Error");
                }
            }
            else
            {
                MensajeHelper.MostrarError("Ingrese un motivo.", "Error");
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
    }
}
