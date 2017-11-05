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
        Usuario usuario;
        AltaAbmCliente form; 
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
            if (form == null)
            {
                Cliente cliente = new Cliente();
                form = new AltaAbmCliente();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
