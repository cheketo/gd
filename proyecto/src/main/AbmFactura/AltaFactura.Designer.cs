namespace PagoAgilFrba
{
    public partial class AltaFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaFactura));
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerAlta = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerVencimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSigno = new System.Windows.Forms.Label();
            this.labelImporte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxNumero.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNumero.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxNumero.Location = new System.Drawing.Point(185, 98);
            this.textBoxNumero.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(160, 22);
            this.textBoxNumero.TabIndex = 13;
            this.textBoxNumero.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNumero_Validating);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonGuardar.Location = new System.Drawing.Point(138, 530);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(160, 49);
            this.buttonGuardar.TabIndex = 12;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelNombre.Location = new System.Drawing.Point(107, 102);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(57, 16);
            this.labelNombre.TabIndex = 11;
            this.labelNombre.Text = "Número";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(113, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCliente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCliente.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Location = new System.Drawing.Point(185, 25);
            this.comboBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(160, 24);
            this.comboBoxCliente.TabIndex = 20;
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEmpresa.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpresa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(185, 62);
            this.comboBoxEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEmpresa.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(99, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Empresa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(60, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Fecha de Alta";
            // 
            // dateTimePickerAlta
            // 
            this.dateTimePickerAlta.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePickerAlta.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dateTimePickerAlta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerAlta.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerAlta.Location = new System.Drawing.Point(185, 133);
            this.dateTimePickerAlta.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerAlta.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerAlta.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAlta.Name = "dateTimePickerAlta";
            this.dateTimePickerAlta.Size = new System.Drawing.Size(160, 22);
            this.dateTimePickerAlta.TabIndex = 24;
            // 
            // dateTimePickerVencimiento
            // 
            this.dateTimePickerVencimiento.CalendarForeColor = System.Drawing.Color.DarkSlateGray;
            this.dateTimePickerVencimiento.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dateTimePickerVencimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePickerVencimiento.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerVencimiento.Location = new System.Drawing.Point(185, 167);
            this.dateTimePickerVencimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerVencimiento.MaxDate = new System.DateTime(2999, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerVencimiento.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerVencimiento.Name = "dateTimePickerVencimiento";
            this.dateTimePickerVencimiento.Size = new System.Drawing.Size(160, 22);
            this.dateTimePickerVencimiento.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(72, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Vencimiento";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nro,
            this.Monto,
            this.Cantidad,
            this.Eliminar});
            this.dataGridViewItems.Location = new System.Drawing.Point(13, 273);
            this.dataGridViewItems.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(413, 235);
            this.dataGridViewItems.TabIndex = 27;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellContentClick);
            this.dataGridViewItems.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellEndEdit);
            this.dataGridViewItems.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dataGridViewItems_CellValidating);
            this.dataGridViewItems.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewItems_RowsAdded);
            this.dataGridViewItems.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewItems_RowsRemoved);
            // 
            // Nro
            // 
            this.Nro.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.Nro.DefaultCellStyle = dataGridViewCellStyle1;
            this.Nro.Frozen = true;
            this.Nro.HeaderText = "N° Item";
            this.Nro.MaxInputLength = 3;
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            this.Nro.Width = 82;
            // 
            // Monto
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = "0";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.Monto.DefaultCellStyle = dataGridViewCellStyle2;
            this.Monto.Frozen = true;
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Cantidad
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Linen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.Frozen = true;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.NullValue = "Eliminar";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle4;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Eliminar.Frozen = true;
            this.Eliminar.HeaderText = "";
            this.Eliminar.MinimumWidth = 2;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Text = "X";
            this.Eliminar.Width = 68;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(72, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Importe Total:";
            // 
            // labelSigno
            // 
            this.labelSigno.AutoSize = true;
            this.labelSigno.Location = new System.Drawing.Point(182, 204);
            this.labelSigno.Name = "labelSigno";
            this.labelSigno.Size = new System.Drawing.Size(16, 16);
            this.labelSigno.TabIndex = 29;
            this.labelSigno.Text = "$";
            // 
            // labelImporte
            // 
            this.labelImporte.AutoSize = true;
            this.labelImporte.BackColor = System.Drawing.Color.Transparent;
            this.labelImporte.Location = new System.Drawing.Point(193, 205);
            this.labelImporte.Name = "labelImporte";
            this.labelImporte.Size = new System.Drawing.Size(16, 16);
            this.labelImporte.TabIndex = 30;
            this.labelImporte.Text = "0";
            // 
            // AltaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(439, 614);
            this.Controls.Add(this.labelImporte);
            this.Controls.Add(this.labelSigno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.dateTimePickerVencimiento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerAlta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNombre);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Factura - Pago Agil FRBA App";
            this.Load += new System.EventHandler(this.AltaFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlta;
        private System.Windows.Forms.DateTimePicker dateTimePickerVencimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSigno;
        private System.Windows.Forms.Label labelImporte;
    }
}