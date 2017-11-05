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

namespace PagoAgilFrba.AbmCliente
{
    public partial class AltaAbmCliente : Form
    {

        Cliente cliente;
 
        public AltaAbmCliente(Cliente cliente = null)
        {
            InitializeComponent();
            this.cliente = cliente;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            if (cliente != null )
            {
                CargarDatosFormulario();
                setEdicionFormulario(false);
                this.Text = "Cliente";
            } else
            {
                cliente = new Cliente();
                buttonCancelar.Visible = false;
                lLEditar.Visible = false;
                this.Text = "Cliente - Alta";
            }
            
        }

        private void lLEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            setEdicionFormulario(true);
            ControlHelper.SetAllCheckBoxRedOnly(this, false);
            this.Text = "Cliente - Modificacion";

        }


        private void tBDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHelper.SoloNumerosEvento(sender, e);
        }

        private void tBCP_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHelper.SoloNumerosEvento(sender, e);
        }

        private void tBNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHelper.SoloLetrasEvento(sender, e);
        }
 
        private void tBApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHelper.SoloLetrasEvento(sender, e);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

            cliente.Dni = tBDni.Text;
            cliente.Apellido = tBApellido.Text;
            cliente.Nombre = tBNombre.Text;
            cliente.FechaNacimiento = dTPFechaNacimiento.Value;
            cliente.Mail = tBMail.Text;
            cliente.Direccion = tbDireccion.Text;
            cliente.CP = tBCP.Text;
            cliente.Piso = tBPiso.Text;
            cliente.Depto = tBDepartamento.Text;
            cliente.Telefono = tBTelefono.Text;
            cliente.Localidad = tBLocalidad.Text;
            cliente.Estado = FormatoHelper.getEstadoFormatter(cBHabilitado);

            if (ValidadorHelper.ValidarAllCampos(this))
            {
                cliente.Save();
                this.Close();
            } else
            {
                MensajeHelper.MostrarError("Verifique los campos ingresados", "Error");
            }

            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            CargarDatosFormulario();
            setEdicionFormulario(false);

        }

        private void CargarDatosFormulario()
        {
            tBNombre.Text = cliente.Nombre;
            tBDni.Text = cliente.Dni;
            tBApellido.Text = cliente.Apellido;
            dTPFechaNacimiento.Text = cliente.FechaNacimiento.ToString();
            tBMail.Text = cliente.Mail;
            tbDireccion.Text = cliente.Direccion;
            tBCP.Text = cliente.CP;
            tBPiso.Text = cliente.CP;
            tBDepartamento.Text = cliente.Depto;
            tBTelefono.Text = cliente.Telefono;
            tBLocalidad.Text = cliente.Localidad;
            cBHabilitado.Checked = FormatoHelper.setCheckedFromEstado(cliente.Estado);
        }

        private void setEdicionFormulario(Boolean editable)
        {
            if(editable)
            {
                buttonGuardar.Visible = true;
                buttonCancelar.Visible = true;
                lLEditar.Visible = false;
                cBHabilitado.Enabled = true;
                dTPFechaNacimiento.Enabled = true;
            } else
            {
                buttonGuardar.Visible = false;
                buttonCancelar.Visible = false;
                ControlHelper.SetAllCheckBoxRedOnly(this, true);
                cBHabilitado.Enabled = false;
                dTPFechaNacimiento.Enabled = false;
                lLEditar.Visible = true;
            }
        }

    }
}
