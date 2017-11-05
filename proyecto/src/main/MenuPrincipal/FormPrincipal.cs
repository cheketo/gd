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
    public partial class FormPrincipal : Form
    {
        public Usuario usuario;
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

        FormEmpresa formEmpresa;
        private void verEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(formEmpresa == null)
            {
                formEmpresa = new FormEmpresa();
                formEmpresa.MdiParent = this;
                formEmpresa.Show();
            }
        }

        private void cargarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaEmpresa altaForm = new AltaEmpresa(formEmpresa);
            altaForm.Show();
        }
    }
}
