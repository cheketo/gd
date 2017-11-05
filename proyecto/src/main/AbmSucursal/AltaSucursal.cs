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
    public partial class AltaSucursal : Form
    {
        public Sucursal obj;
        public FormSucursal formPadre;
        public AltaSucursal(FormSucursal padre = null)
        {
            formPadre = padre;
            obj = new Sucursal();
            InitializeComponent();
            Sucursal.CargarComboEstado(comboBoxEstado);
        }

        private void AltaSucursal_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Boolean validaciones =
            ValidadorHelper.ValidarTextBox(textBoxNombre) &&
            ValidadorHelper.ValidarTextBox(textBoxCp) &&
            ValidadorHelper.ValidarTextBox(textBoxDireccion);
            if (validaciones)
            {
                if (obj.Validar(textBoxCp.Text))
                {
                    if (MensajeHelper.MostrarConfirmacion("¿Desea crear la sucursal " + textBoxNombre.Text + "?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                    {
                        obj.Nombre = textBoxNombre.Text;
                        obj.Cp = textBoxCp.Text;
                        obj.Direccion = textBoxDireccion.Text;
                        int indexEstado = Convert.ToInt32(comboBoxEstado.SelectedValue.ToString());
                        if (indexEstado == 1)
                            obj.Estado = "A";
                        else
                            obj.Estado = "I";
                     obj.Guardar();
                        if (formPadre != null)
                        {
                            formPadre.CaragarView();
                        }
                        this.Dispose();
                    }
                }
                else
                {
                    MensajeHelper.MostrarError("El código postal de la sucursal ya se encuentra cargado en la base de datos.", "Error");
                }
            }else{
                MensajeHelper.MostrarWarning("Complete todos los campos.", "Error");
            }

        }
    }
}
