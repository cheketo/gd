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
    public partial class AltaFactura : Form
    {
        public Factura obj;
        public Usuario usuario;
        public FormPrincipal padre;

        public AltaFactura(FormPrincipal principal)
        {
            this.usuario = principal.usuario;
            this.padre = principal;
            obj = new Factura();
            InitializeComponent();
            Cliente.LlenarComboBox(comboBoxCliente);
            Empresa.LlenarComboBox(comboBoxEmpresa);
            if (usuario.TempId>0)
                comboBoxCliente.SelectedValue = usuario.TempId;
            dateTimePickerAlta.MaxDate = DateTime.Today;
            dateTimePickerVencimiento.MinDate = DateTime.Today;
        }

        private void AltaFactura_Load(object sender, EventArgs e)
        {
            dataGridViewItems.Rows[0].Cells["Nro"].Value = "1";
            //dataGridViewItems.Columns["Eliminar"].Visible = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            GuardarFactura();
            padre.MostrarCargarFactura();
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            GuardarFactura();
            padre.MostrarCargarPago();
        }

        private void GuardarFactura()
        {
            Boolean validaciones =
            ValidadorHelper.ValidarTextBox(textBoxNumero);
            if (validaciones)
            {
                Decimal importe = Convert.ToDecimal(labelImporte.Text);
                if (obj.Validar(dataGridViewItems, importe))
                {
                    if (MensajeHelper.MostrarConfirmacion("¿Desea cargar la factura?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                    {
                        obj.Numero = Convert.ToInt64(textBoxNumero.Text);
                        obj.IdCliente = Convert.ToInt32(comboBoxCliente.SelectedValue.ToString());
                        obj.IdEmpresa = Convert.ToInt32(comboBoxEmpresa.SelectedValue.ToString());
                        obj.Fecha = dateTimePickerAlta.Text;
                        obj.FechaVencimiento = dateTimePickerVencimiento.Text;
                        obj.IdSucursal = usuario.IdSucursal;
                        obj.Importe = importe;
                        obj.ItemsNuevos = dataGridViewItems;
                        padre.usuario.TempId = obj.IdCliente;
                        obj.Guardar();
                        this.Dispose();
                    }
                }
                else
                {
                    MensajeHelper.MostrarError("La factura debe tener un importe mayor a $0.", "Error");
                }
            }
            else
            {
                MensajeHelper.MostrarWarning("Complete todos los campos.", "Error");
            }
        }

        private void dataGridViewItems_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int fila = dataGridViewItems.RowCount;
            dataGridViewItems.Rows[e.RowIndex].Cells["Nro"].Value = fila;
            //dataGridViewItems.Columns["Eliminar"].Visible = true;
        }

        public void CalcularImporte()
        {
            decimal importe = 0;
            foreach (DataGridViewRow row in dataGridViewItems.Rows)
            {
                if (!row.IsNewRow)
                {

                    importe = importe + Convert.ToDecimal(row.Cells["Monto"].FormattedValue.ToString()) * Convert.ToDecimal(row.Cells["Cantidad"].FormattedValue.ToString());
                }
            }
            labelImporte.Text = importe.ToString();
        }

        private void dataGridViewItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridViewItems.Rows[e.RowIndex].ErrorText = String.Empty;
            CalcularImporte();
        }

        private void dataGridViewItems_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            string columna = dataGridViewItems.Columns[e.ColumnIndex].Name;
            if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
            {
                dataGridViewItems.Rows[e.RowIndex].ErrorText =
                    "Ingrese un valor.";
                e.Cancel = true;
            }
            else
            {
                if (columna == "Cantidad")
                {
                    if (!int.TryParse(dataGridViewItems.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString(), out var result))
                    {
                        dataGridViewItems.Rows[e.RowIndex].ErrorText =
                        "Ingrese un número entero.";
                        e.Cancel = true;
                    }
                }

                if (columna == "Monto")
                {
                    if (!float.TryParse(dataGridViewItems.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString(), out var result))
                    {
                        dataGridViewItems.Rows[e.RowIndex].ErrorText =
                        "Ingrese un número decimal.";
                        e.Cancel = true;
                    }
                }
            }
        }

        private void dataGridViewItems_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            for (int i = 0; i < dataGridViewItems.Rows.Count; i++)
            {
                dataGridViewItems.Rows[i].Cells["Nro"].Value = i + 1;
            }
            CalcularImporte();
        }

        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columna = dataGridViewItems.Columns[e.ColumnIndex].Name;
            if(columna=="Eliminar" && !dataGridViewItems.Rows[e.RowIndex].IsNewRow)
            {
                dataGridViewItems.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void textBoxNumero_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNumero.Text))
            {
                MensajeHelper.MostrarError("Ingrese un número.", "Pago Agil FRBA App");
                e.Cancel = true;
            }
            else
            {
                if (!Int64.TryParse(textBoxNumero.Text, out var result))
                {
                    MensajeHelper.MostrarError("Ingrese únicamente números.", "Pago Agil FRBA App");
                    e.Cancel = true;
                }
            }

            
        }
    }
}
