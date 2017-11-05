﻿using System;
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
        public AltaAbmCliente formCliente;
        public VerAbmCliente formVerClientes;
        public FormEmpresa formEmpresa;
        public AltaEmpresa altaEmpresa;
        public FormSucursal formSucursal;
        public AltaSucursal altaSucursal;

        public FormPrincipal(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            //MessageBox.Show("Usuario: " + usuario.User + " - Rol: " + usuario.NombreRol);
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
            if (this.formVerClientes == null || this.formVerClientes.IsDisposed)
            {
                VerAbmCliente formVerClientes = new VerAbmCliente();
                formVerClientes.MdiParent = this;
                formVerClientes.Show();
                this.formVerClientes = formVerClientes;
            }
            else
                formVerClientes.Activate();
        }

        private void verEmpresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formEmpresa == null || this.formEmpresa.IsDisposed)
            {
                FormEmpresa formEmpresa = new FormEmpresa();
                formEmpresa.MdiParent = this;
                formEmpresa.Show();
                this.formEmpresa = formEmpresa;
            }
            else
                formEmpresa.Activate();
        }

        private void cargarEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (altaEmpresa == null)
            {
                AltaEmpresa altaForm = new AltaEmpresa(formEmpresa);
                altaForm.MdiParent = this;
                altaForm.Show();
            }
        }

        private void verSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formSucursal == null || this.formSucursal.IsDisposed)
            {
                FormSucursal formSucursal = new FormSucursal();
                formSucursal.MdiParent = this;
                formSucursal.Show();
                this.formSucursal = formSucursal;
            }
            else
                formSucursal.Activate();

        }

        private void cargarSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (altaSucursal == null)
            {
                AltaSucursal altaForm = new AltaSucursal(formSucursal);
                altaForm.Show();
            }
        }
        
    }
}
