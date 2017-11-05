namespace PagoAgilFrba
{
    public partial class EditarSucursal
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxCp = new System.Windows.Forms.TextBox();
            this.labelCp = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.comboBoxEstado = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(58, 41);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(101, 220);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(105, 38);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // textBoxCp
            // 
            this.textBoxCp.Location = new System.Drawing.Point(105, 74);
            this.textBoxCp.Name = "textBoxCp";
            this.textBoxCp.Size = new System.Drawing.Size(121, 20);
            this.textBoxCp.TabIndex = 4;
            // 
            // labelCp
            // 
            this.labelCp.AutoSize = true;
            this.labelCp.Location = new System.Drawing.Point(30, 77);
            this.labelCp.Name = "labelCp";
            this.labelCp.Size = new System.Drawing.Size(72, 13);
            this.labelCp.TabIndex = 3;
            this.labelCp.Text = "Código Postal";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(105, 114);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(121, 20);
            this.textBoxDireccion.TabIndex = 6;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(51, 117);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(52, 13);
            this.labelDireccion.TabIndex = 5;
            this.labelDireccion.Text = "Direccion";
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Location = new System.Drawing.Point(62, 157);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado";
            // 
            // comboBoxEstado
            // 
            this.comboBoxEstado.FormattingEnabled = true;
            this.comboBoxEstado.Location = new System.Drawing.Point(105, 154);
            this.comboBoxEstado.Name = "comboBoxEstado";
            this.comboBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEstado.TabIndex = 8;
            // 
            // EditarSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelEstado);
            this.Controls.Add(this.comboBoxEstado);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.textBoxCp);
            this.Controls.Add(this.labelCp);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNombre);
            this.Name = "EditarSucursal";
            this.Text = "Editar Sucursal - Pago Agil FRBA App";
            this.Load += new System.EventHandler(this.EditarSucursal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxCp;
        private System.Windows.Forms.Label labelCp;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.ComboBox comboBoxEstado;
        //private System.Windows.Forms.Label label1;
        //private System.Windows.Forms.ComboBox comboBoxRubro;
        //private System.Windows.Forms.TextBox textBoxPorcentaje;
        //private System.Windows.Forms.Label label2;
    }
}