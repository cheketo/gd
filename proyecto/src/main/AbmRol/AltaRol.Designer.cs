namespace PagoAgilFrba
{
    public partial class AltaRol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaRol));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.checkedListBoxFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.AliceBlue;
            this.textBoxNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxNombre.Location = new System.Drawing.Point(112, 33);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(121, 22);
            this.textBoxNombre.TabIndex = 13;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonGuardar.Location = new System.Drawing.Point(82, 300);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(120, 40);
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
            this.labelNombre.Location = new System.Drawing.Point(52, 36);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(57, 16);
            this.labelNombre.TabIndex = 11;
            this.labelNombre.Text = "Nombre";
            // 
            // checkedListBoxFuncionalidades
            // 
            this.checkedListBoxFuncionalidades.BackColor = System.Drawing.Color.AliceBlue;
            this.checkedListBoxFuncionalidades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBoxFuncionalidades.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxFuncionalidades.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.checkedListBoxFuncionalidades.FormattingEnabled = true;
            this.checkedListBoxFuncionalidades.Location = new System.Drawing.Point(82, 94);
            this.checkedListBoxFuncionalidades.Name = "checkedListBoxFuncionalidades";
            this.checkedListBoxFuncionalidades.Size = new System.Drawing.Size(120, 172);
            this.checkedListBoxFuncionalidades.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(88, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Funcionalidades";
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(284, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxFuncionalidades);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.labelNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AltaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargar Rol - Pago Agil FRBA App";
            this.Load += new System.EventHandler(this.AltaRol_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.CheckedListBox checkedListBoxFuncionalidades;
        private System.Windows.Forms.Label label1;
    }
}