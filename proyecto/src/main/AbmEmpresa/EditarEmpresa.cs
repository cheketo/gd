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
    public partial class EditarEmpresa : Form
    {
        public Empresa empresa;
        public FormEmpresa formPadre;
        public EditarEmpresa(Empresa empresa, FormEmpresa padre = null)
        {
            formPadre = padre;
            this.empresa = empresa;
            InitializeComponent();
            Rubro.CargarComboBox(comboBoxRubro);

            textBoxNombre.Text = empresa.Nombre;
            textBoxCuit.Text = empresa.Cuit;
            textBoxDireccion.Text = empresa.Direccion;
            comboBoxRubro.SelectedValue = empresa.IdRubro;
            textBoxPorcentaje.Text = empresa.Porcentaje.ToString();
        }

        private void EditarEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            ValidadorHelper.ValidarTextBox(textBoxNombre);
            ValidadorHelper.ValidarTextBox(textBoxCuit);
            ValidadorHelper.ValidarTextBox(textBoxDireccion);
            ValidadorHelper.ValidarTextBox(textBoxPorcentaje);
            if (MensajeHelper.MostrarConfirmacion("¿Desea guardar los cambios?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
            {
                empresa.Nombre = textBoxNombre.Text;
                empresa.Cuit = textBoxCuit.Text;
                empresa.Direccion = textBoxDireccion.Text;
                empresa.IdRubro = Convert.ToInt32(comboBoxRubro.SelectedValue.ToString());
                empresa.Porcentaje = Convert.ToDecimal(textBoxPorcentaje.Text);
                empresa.Modificar();
                if(formPadre!=null)
                {
                    formPadre.CaragarView();
                }
                this.Dispose();
            }
        }

        private void textBoxPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHelper.SoloNumerosDecimalEvento(sender, e);
        }
    }
}
