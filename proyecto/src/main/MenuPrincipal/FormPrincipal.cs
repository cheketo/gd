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
using PagoAgilFrba.AbmCliente;

namespace PagoAgilFrba
{
    public partial class FormPrincipal : Form
    {
        public Usuario usuario;
        AltaAbmCliente formCliente; 
        FormEmpresa formEmpresa;
        AltaEmpresa altaEmpresa;
        VerAbmCliente formVerClientes;

        public FormPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            MessageBox.Show("Usuario: " + usuario.User + " - Rol: " + usuario.NombreRol);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlHelper.CerrarApp();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControlHelper.CerrarSesionApp();
        }

        private void altaClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCliente == null)
            {
                Cliente cliente = new Cliente();
                formCliente = new AltaAbmCliente();
                formCliente.MdiParent = this;
                formCliente.Show();
            }
        }

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formVerClientes == null )
            {
                formVerClientes = new VerAbmCliente();
                formVerClientes.MdiParent = this;
                formVerClientes.Show();
            }
        }

        private void cargarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(altaEmpresa == null)
            {
                AltaEmpresa altaForm = new AltaEmpresa(formEmpresa);
                altaForm.Show();
            }
        }

    }
}
