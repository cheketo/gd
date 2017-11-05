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
    public partial class AltaEmpresa : Form
    {
        public Empresa empresa;
        public FormEmpresa formPadre;
        public AltaEmpresa(FormEmpresa padre = null)
        {
            formPadre = padre;
            empresa = new Empresa();
            InitializeComponent();
            Rubro.CargarComboBox(comboBoxRubro);
        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Boolean validaciones =
            ValidadorHelper.ValidarTextBox(textBoxNombre) &&
            ValidadorHelper.ValidarTextBox(textBoxCuit) &&
            ValidadorHelper.ValidarTextBox(textBoxDireccion);
            if (validaciones)
            {
                if (empresa.ValidarEmpresa(textBoxNombre.Text, textBoxCuit.Text))
                {
                    if (MensajeHelper.MostrarConfirmacion("¿Desea crear la empresa " + textBoxNombre.Text + "?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                    {
                        empresa.Nombre = textBoxNombre.Text;
                        empresa.Cuit = textBoxCuit.Text;
                        empresa.Direccion = textBoxDireccion.Text;
                        empresa.IdRubro = Convert.ToInt32(comboBoxRubro.SelectedValue.ToString());
                        empresa.Guardar();
                        if (formPadre != null)
                        {
                            formPadre.CaragarView();
                        }
                        this.Dispose();
                    }
                }
                else
                {
                    MensajeHelper.MostrarError("El nombre o el CUIT de la empresa ya se encuentra cargado en la base de datos.", "Error");
                }
            }else{
                MensajeHelper.MostrarWarning("Complete todos los campos.", "Error");
            }

        }
    }
}
