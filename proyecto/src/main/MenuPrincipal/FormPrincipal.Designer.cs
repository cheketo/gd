namespace PagoAgilFrba
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verEmpresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarEmpresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verRolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarRolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosYFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pagarFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverPagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.empresasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.sucursalesToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.pagosYFacturasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(685, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.usuarioToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEmpresasToolStripMenuItem,
            this.cargarEmpresaToolStripMenuItem});
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.empresasToolStripMenuItem.Text = "Empresas";
            // 
            // verEmpresasToolStripMenuItem
            // 
            this.verEmpresasToolStripMenuItem.Name = "verEmpresasToolStripMenuItem";
            this.verEmpresasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.verEmpresasToolStripMenuItem.Text = "Ver Empresas";
            this.verEmpresasToolStripMenuItem.Click += new System.EventHandler(this.verEmpresasToolStripMenuItem_Click);
            // 
            // cargarEmpresaToolStripMenuItem
            // 
            this.cargarEmpresaToolStripMenuItem.Name = "cargarEmpresaToolStripMenuItem";
            this.cargarEmpresaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cargarEmpresaToolStripMenuItem.Text = "Cargar Empresa";
            this.cargarEmpresaToolStripMenuItem.Click += new System.EventHandler(this.cargarEmpresaToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarClienteToolStripMenuItem,
            this.altaClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.buscarClienteToolStripMenuItem.Text = "Ver Clientes";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // altaClienteToolStripMenuItem
            // 
            this.altaClienteToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.altaClienteToolStripMenuItem.Name = "altaClienteToolStripMenuItem";
            this.altaClienteToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.altaClienteToolStripMenuItem.Text = "Cargar Cliente";
            this.altaClienteToolStripMenuItem.Click += new System.EventHandler(this.altaClienteToolStripMenuItem_Click);
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verSucursalesToolStripMenuItem,
            this.cargarSucursalToolStripMenuItem});
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            // 
            // verSucursalesToolStripMenuItem
            // 
            this.verSucursalesToolStripMenuItem.Name = "verSucursalesToolStripMenuItem";
            this.verSucursalesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.verSucursalesToolStripMenuItem.Text = "Ver Sucursales";
            this.verSucursalesToolStripMenuItem.Click += new System.EventHandler(this.verSucursalesToolStripMenuItem_Click);
            // 
            // cargarSucursalToolStripMenuItem
            // 
            this.cargarSucursalToolStripMenuItem.Name = "cargarSucursalToolStripMenuItem";
            this.cargarSucursalToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cargarSucursalToolStripMenuItem.Text = "Cargar Sucursal";
            this.cargarSucursalToolStripMenuItem.Click += new System.EventHandler(this.cargarSucursalToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRolesToolStripMenuItem,
            this.cargarRolToolStripMenuItem});
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rolesToolStripMenuItem.Text = "Roles";
            // 
            // verRolesToolStripMenuItem
            // 
            this.verRolesToolStripMenuItem.Name = "verRolesToolStripMenuItem";
            this.verRolesToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.verRolesToolStripMenuItem.Text = "Ver Roles";
            this.verRolesToolStripMenuItem.Click += new System.EventHandler(this.verRolesToolStripMenuItem_Click);
            // 
            // cargarRolToolStripMenuItem
            // 
            this.cargarRolToolStripMenuItem.Name = "cargarRolToolStripMenuItem";
            this.cargarRolToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.cargarRolToolStripMenuItem.Text = "Cargar Rol";
            this.cargarRolToolStripMenuItem.Click += new System.EventHandler(this.cargarRolToolStripMenuItem_Click);
            // 
            // pagosYFacturasToolStripMenuItem
            // 
            this.pagosYFacturasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarFacturaToolStripMenuItem,
            this.pagarFacturasToolStripMenuItem,
            this.devolverPagoToolStripMenuItem});
            this.pagosYFacturasToolStripMenuItem.Name = "pagosYFacturasToolStripMenuItem";
            this.pagosYFacturasToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.pagosYFacturasToolStripMenuItem.Text = "Facturas";
            // 
            // cargarFacturaToolStripMenuItem
            // 
            this.cargarFacturaToolStripMenuItem.Name = "cargarFacturaToolStripMenuItem";
            this.cargarFacturaToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cargarFacturaToolStripMenuItem.Text = "Cargar Factura";
            this.cargarFacturaToolStripMenuItem.Click += new System.EventHandler(this.cargarFacturaToolStripMenuItem_Click);
            // 
            // pagarFacturasToolStripMenuItem
            // 
            this.pagarFacturasToolStripMenuItem.Name = "pagarFacturasToolStripMenuItem";
            this.pagarFacturasToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.pagarFacturasToolStripMenuItem.Text = "Pagar Facturas";
            this.pagarFacturasToolStripMenuItem.Click += new System.EventHandler(this.pagarFacturasToolStripMenuItem_Click);
            // 
            // devolverPagoToolStripMenuItem
            // 
            this.devolverPagoToolStripMenuItem.Name = "devolverPagoToolStripMenuItem";
            this.devolverPagoToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.devolverPagoToolStripMenuItem.Text = "Devolver Facturas";
            this.devolverPagoToolStripMenuItem.Click += new System.EventHandler(this.devolverPagoToolStripMenuItem_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(685, 262);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Agil FRBA App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verEmpresasToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cargarEmpresaToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem altaClienteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verSucursalesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cargarSucursalToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem verRolesToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cargarRolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagosYFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pagarFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverPagoToolStripMenuItem;
    }
}