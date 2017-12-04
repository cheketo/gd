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
    public partial class EditarRol : Form
    {
        public Rol obj;
        public FormRol formPadre;
        public EditarRol(Rol obj, FormRol padre = null)
        {
            formPadre = padre;
            this.obj = obj;
            InitializeComponent();
            
            Rol.CargarFuncionalidades(checkedListBoxFuncionalidades, obj);
            textBoxNombre.Text = obj.Nombre;
        }

        private void EditarRol_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Boolean validaciones =
             ValidadorHelper.ValidarTextBox(textBoxNombre);
            if (validaciones)
            {
                if (obj.Validar(textBoxNombre.Text, obj.Id))
                {
                    if (MensajeHelper.MostrarConfirmacion("¿Desea guardar los cambios?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                    {
                        obj.Nombre = textBoxNombre.Text;
                        obj.FuncionalidadesSeleccionadas = Rol.ObtenerFuncionalidadesSeleccionadas(checkedListBoxFuncionalidades);
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
                    MensajeHelper.MostrarError("Ya existe un rol con el nombre '" + textBoxNombre.Text + "'.", "Error");
                }
            }
            else
            {
                MensajeHelper.MostrarWarning("Complete todos los campos.", "Error");
            }
        }
    }
}
