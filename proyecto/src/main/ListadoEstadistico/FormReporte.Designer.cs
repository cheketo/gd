namespace PagoAgilFrba.ListadoEstadistico
{
    public partial class FormReporte
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
            this.labelAnio = new System.Windows.Forms.Label();
            this.cBAnio = new System.Windows.Forms.ComboBox();
            this.labelTrimestre = new System.Windows.Forms.Label();
            this.cBTrimestre = new System.Windows.Forms.ComboBox();
            this.labelTipoReporte = new System.Windows.Forms.Label();
            this.cBReporte = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelAnio.Location = new System.Drawing.Point(41, 41);
            this.labelAnio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(28, 15);
            this.labelAnio.TabIndex = 15;
            this.labelAnio.Text = "Año";
            // 
            // cBAnio
            // 
            this.cBAnio.BackColor = System.Drawing.Color.AliceBlue;
            this.cBAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAnio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBAnio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBAnio.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cBAnio.FormattingEnabled = true;
            this.cBAnio.Location = new System.Drawing.Point(141, 38);
            this.cBAnio.Margin = new System.Windows.Forms.Padding(4);
            this.cBAnio.Name = "cBAnio";
            this.cBAnio.Size = new System.Drawing.Size(160, 23);
            this.cBAnio.TabIndex = 21;
            this.cBAnio.SelectedIndexChanged += new System.EventHandler(this.cBAnio_SelectedIndexChanged);
            // 
            // labelTrimestre
            // 
            this.labelTrimestre.AutoSize = true;
            this.labelTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrimestre.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTrimestre.Location = new System.Drawing.Point(41, 88);
            this.labelTrimestre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrimestre.Name = "labelTrimestre";
            this.labelTrimestre.Size = new System.Drawing.Size(59, 15);
            this.labelTrimestre.TabIndex = 22;
            this.labelTrimestre.Text = "Trimestre";
            // 
            // cBTrimestre
            // 
            this.cBTrimestre.BackColor = System.Drawing.Color.AliceBlue;
            this.cBTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBTrimestre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBTrimestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBTrimestre.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cBTrimestre.FormattingEnabled = true;
            this.cBTrimestre.Location = new System.Drawing.Point(141, 87);
            this.cBTrimestre.Margin = new System.Windows.Forms.Padding(4);
            this.cBTrimestre.Name = "cBTrimestre";
            this.cBTrimestre.Size = new System.Drawing.Size(160, 23);
            this.cBTrimestre.TabIndex = 23;
            // 
            // labelTipoReporte
            // 
            this.labelTipoReporte.AutoSize = true;
            this.labelTipoReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoReporte.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelTipoReporte.Location = new System.Drawing.Point(41, 131);
            this.labelTipoReporte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoReporte.Name = "labelTipoReporte";
            this.labelTipoReporte.Size = new System.Drawing.Size(51, 15);
            this.labelTipoReporte.TabIndex = 24;
            this.labelTipoReporte.Text = "Reporte";
            // 
            // cBReporte
            // 
            this.cBReporte.BackColor = System.Drawing.Color.AliceBlue;
            this.cBReporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBReporte.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cBReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBReporte.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cBReporte.FormattingEnabled = true;
            this.cBReporte.Location = new System.Drawing.Point(141, 130);
            this.cBReporte.Margin = new System.Windows.Forms.Padding(4);
            this.cBReporte.Name = "cBReporte";
            this.cBReporte.Size = new System.Drawing.Size(326, 23);
            this.cBReporte.TabIndex = 25;
            // 
            // FormReporte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(744, 611);
            this.Controls.Add(this.cBReporte);
            this.Controls.Add(this.labelTipoReporte);
            this.Controls.Add(this.cBTrimestre);
            this.Controls.Add(this.labelTrimestre);
            this.Controls.Add(this.cBAnio);
            this.Controls.Add(this.labelAnio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReporte";
            this.Text = "Reportes - Pago Agil FRBA App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.ComboBox cBAnio;
        private System.Windows.Forms.Label labelTrimestre;
        private System.Windows.Forms.ComboBox cBTrimestre;
        private System.Windows.Forms.Label labelTipoReporte;
        private System.Windows.Forms.ComboBox cBReporte;
    }
}