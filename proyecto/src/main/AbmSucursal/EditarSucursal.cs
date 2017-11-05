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
    public partial class EditarSucursal : Form
    {
        public Sucursal obj;
        public FormSucursal formPadre;
        public EditarSucursal(Sucursal obj, FormSucursal padre = null)
        {
            formPadre = padre;
            this.obj = obj;
            InitializeComponent();
            Sucursal.CargarComboEstado(comboBoxEstado);

            textBoxNombre.Text = obj.Nombre;
            textBoxCp.Text = obj.Cp;
            textBoxDireccion.Text = obj.Direccion;
            int comboIndex = 1;
            if(obj.Estado == "I")
                comboIndex = 2;
            comboBoxEstado.SelectedValue = comboIndex;
            //comboBoxRubro.SelectedValue = obj.IdRubro;
            //textBoxPorcentaje.Text = obsj.Porcentaje.ToString();
            //MessageBox.Show(empresa.Id.ToString());
        }

        private void EditarSucursal_Load(object sender, EventArgs e)
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
                if (obj.Validar(textBoxCp.Text, obj.Id))
                {
                    if (MensajeHelper.MostrarConfirmacion("¿Desea guardar los cambios?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                    {
                        obj.Nombre = textBoxNombre.Text;
                        obj.Cp = textBoxCp.Text;
                        obj.Direccion = textBoxDireccion.Text;
                        int indexEstado = Convert.ToInt32(comboBoxEstado.SelectedValue.ToString());
                        if (indexEstado != 1)
                            obj.Estado = "I";
                        else
                            obj.Estado = "A";
                        obj.Modificar();
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
            }
            else
            {
                MensajeHelper.MostrarWarning("Complete todos los campos.", "Error");
            }
        }
    }
}
