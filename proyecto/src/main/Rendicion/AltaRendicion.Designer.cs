namespace PagoAgilFrba
{
    public partial class AltaRendicion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaRendicion));
            this.buttonRendir = new System.Windows.Forms.Button();
            this.label99 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelFacturas = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxComision = new System.Windows.Forms.MaskedTextBox();
            this.labelComision = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRendir
            // 
            this.buttonRendir.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonRendir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRendir.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRendir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonRendir.Location = new System.Drawing.Point(64, 162);
            this.buttonRendir.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRendir.Name = "buttonRendir";
            this.buttonRendir.Size = new System.Drawing.Size(160, 49);
            this.buttonRendir.TabIndex = 12;
            this.buttonRendir.Text = "Rendir";
            this.buttonRendir.UseVisualStyleBackColor = false;
            this.buttonRendir.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label99
            // 
            this.label99.AutoSize = true;
            this.label99.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label99.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label99.Location = new System.Drawing.Point(35, 33);
            this.label99.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label99.Name = "label99";
            this.label99.Size = new System.Drawing.Size(68, 16);
            this.label99.TabIndex = 14;
            this.label99.Text = "Empresa:";
            // 
            // comboBoxEmpresa
            // 
            this.comboBoxEmpresa.BackColor = System.Drawing.Color.AliceBlue;
            this.comboBoxEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEmpresa.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEmpresa.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxEmpresa.FormattingEnabled = true;
            this.comboBoxEmpresa.Location = new System.Drawing.Point(103, 30);
            this.comboBoxEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxEmpresa.Name = "comboBoxEmpresa";
            this.comboBoxEmpresa.Size = new System.Drawing.Size(160, 24);
            this.comboBoxEmpresa.TabIndex = 20;
            this.comboBoxEmpresa.SelectedValueChanged += new System.EventHandler(this.comboBoxCliente_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Importe a Rendir:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "$";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelTotal.Location = new System.Drawing.Point(161, 69);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(16, 16);
            this.labelTotal.TabIndex = 30;
            this.labelTotal.Text = "0";
            // 
            // labelFacturas
            // 
            this.labelFacturas.AutoSize = true;
            this.labelFacturas.BackColor = System.Drawing.Color.Transparent;
            this.labelFacturas.Location = new System.Drawing.Point(153, 85);
            this.labelFacturas.Name = "labelFacturas";
            this.labelFacturas.Size = new System.Drawing.Size(16, 16);
            this.labelFacturas.TabIndex = 35;
            this.labelFacturas.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(34, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 16);
            this.label4.TabIndex = 33;
            this.label4.Text = "Facturas a Rendir:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(34, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Porcentaje de Comisión:";
            // 
            // maskedTextBoxComision
            // 
            this.maskedTextBoxComision.Location = new System.Drawing.Point(193, 100);
            this.maskedTextBoxComision.Name = "maskedTextBoxComision";
            this.maskedTextBoxComision.Size = new System.Drawing.Size(56, 22);
            this.maskedTextBoxComision.TabIndex = 37;
            this.maskedTextBoxComision.TextChanged += new System.EventHandler(this.maskedTextBoxComision_TextChanged);
            // 
            // labelComision
            // 
            this.labelComision.AutoSize = true;
            this.labelComision.BackColor = System.Drawing.Color.Transparent;
            this.labelComision.Location = new System.Drawing.Point(110, 118);
            this.labelComision.Name = "labelComision";
            this.labelComision.Size = new System.Drawing.Size(16, 16);
            this.labelComision.TabIndex = 40;
            this.labelComision.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(34, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Comisión:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonBuscar.Location = new System.Drawing.Point(64, 162);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(160, 49);
            this.buttonBuscar.TabIndex = 41;
            this.buttonBuscar.Text = "Buscar Rendición";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // AltaRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(302, 239);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.labelComision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBoxComision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFacturas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.label99);
            this.Controls.Add(this.buttonRendir);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaRendicion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendir Facturas - Pago Agil FRBA App";
            this.Load += new System.EventHandler(this.AltaRendicion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRendir;
        private System.Windows.Forms.Label label99;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelFacturas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxComision;
        private System.Windows.Forms.Label labelComision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonBuscar;
    }
}