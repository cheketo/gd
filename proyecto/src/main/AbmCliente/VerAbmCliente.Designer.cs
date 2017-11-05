namespace PagoAgilFrba.AbmCliente
{
    partial class VerAbmCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBDNI = new System.Windows.Forms.TextBox();
            this.labelDNI = new System.Windows.Forms.Label();
            this.tBApellido = new System.Windows.Forms.TextBox();
            this.labelApellido = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dGVClientes = new System.Windows.Forms.DataGridView();
            this.buttonCargarCliente = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBDNI);
            this.groupBox1.Controls.Add(this.labelDNI);
            this.groupBox1.Controls.Add(this.tBApellido);
            this.groupBox1.Controls.Add(this.labelApellido);
            this.groupBox1.Controls.Add(this.tBNombre);
            this.groupBox1.Controls.Add(this.labelNombre);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 60);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // tBDNI
            // 
            this.tBDNI.Location = new System.Drawing.Point(507, 18);
            this.tBDNI.Name = "tBDNI";
            this.tBDNI.Size = new System.Drawing.Size(100, 20);
            this.tBDNI.TabIndex = 5;
            this.tBDNI.Tag = "TextoLibre";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(469, 21);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(32, 13);
            this.labelDNI.TabIndex = 4;
            this.labelDNI.Text = "D.N.I";
            // 
            // tBApellido
            // 
            this.tBApellido.Location = new System.Drawing.Point(277, 18);
            this.tBApellido.Name = "tBApellido";
            this.tBApellido.Size = new System.Drawing.Size(100, 20);
            this.tBApellido.TabIndex = 3;
            this.tBApellido.Tag = "TextoLibre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Location = new System.Drawing.Point(227, 22);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(44, 13);
            this.labelApellido.TabIndex = 2;
            this.labelApellido.Text = "Apellido";
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(62, 22);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(100, 20);
            this.tBNombre.TabIndex = 1;
            this.tBNombre.Tag = "TextoLibre";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(12, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(519, 113);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Tag = "Limpiar";
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(624, 113);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Tag = "Buscar";
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dGVClientes
            // 
            this.dGVClientes.AllowUserToAddRows = false;
            this.dGVClientes.AllowUserToDeleteRows = false;
            this.dGVClientes.AllowUserToOrderColumns = true;
            this.dGVClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVClientes.Location = new System.Drawing.Point(11, 142);
            this.dGVClientes.Name = "dGVClientes";
            this.dGVClientes.ReadOnly = true;
            this.dGVClientes.Size = new System.Drawing.Size(688, 163);
            this.dGVClientes.TabIndex = 6;
            this.dGVClientes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dGVClientes_CellMouseDoubleClick);
            // 
            // buttonCargarCliente
            // 
            this.buttonCargarCliente.Location = new System.Drawing.Point(11, 366);
            this.buttonCargarCliente.Name = "buttonCargarCliente";
            this.buttonCargarCliente.Size = new System.Drawing.Size(102, 23);
            this.buttonCargarCliente.TabIndex = 7;
            this.buttonCargarCliente.Tag = "Cargar";
            this.buttonCargarCliente.Text = "Cargar Cliente";
            this.buttonCargarCliente.UseVisualStyleBackColor = true;
            // 
            // VerAbmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 401);
            this.Controls.Add(this.buttonCargarCliente);
            this.Controls.Add(this.dGVClientes);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Name = "VerAbmCliente";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.VerAbmCliente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tBDNI;
        private System.Windows.Forms.Label labelDNI;
        private System.Windows.Forms.TextBox tBApellido;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dGVClientes;
        private System.Windows.Forms.Button buttonCargarCliente;
    }
}