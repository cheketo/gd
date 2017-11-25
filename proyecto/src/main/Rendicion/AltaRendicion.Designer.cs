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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEmpresa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSigno1 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelProximaRendicion1 = new System.Windows.Forms.Label();
            this.labelProximaRendicion2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxComision = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Empresa:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(34, 68);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Importe a Rendir:";
            // 
            // labelSigno1
            // 
            this.labelSigno1.AutoSize = true;
            this.labelSigno1.Location = new System.Drawing.Point(150, 68);
            this.labelSigno1.Name = "labelSigno1";
            this.labelSigno1.Size = new System.Drawing.Size(16, 16);
            this.labelSigno1.TabIndex = 29;
            this.labelSigno1.Text = "$";
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
            // labelProximaRendicion1
            // 
            this.labelProximaRendicion1.AutoSize = true;
            this.labelProximaRendicion1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProximaRendicion1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelProximaRendicion1.Location = new System.Drawing.Point(34, 52);
            this.labelProximaRendicion1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProximaRendicion1.Name = "labelProximaRendicion1";
            this.labelProximaRendicion1.Size = new System.Drawing.Size(127, 16);
            this.labelProximaRendicion1.TabIndex = 31;
            this.labelProximaRendicion1.Text = "Próxima Rendición:";
            // 
            // labelProximaRendicion2
            // 
            this.labelProximaRendicion2.AutoSize = true;
            this.labelProximaRendicion2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProximaRendicion2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelProximaRendicion2.Location = new System.Drawing.Point(155, 52);
            this.labelProximaRendicion2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProximaRendicion2.Name = "labelProximaRendicion2";
            this.labelProximaRendicion2.Size = new System.Drawing.Size(82, 16);
            this.labelProximaRendicion2.TabIndex = 32;
            this.labelProximaRendicion2.Text = "27/11/2017";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(153, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "0";
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
            this.maskedTextBoxComision.Size = new System.Drawing.Size(31, 22);
            this.maskedTextBoxComision.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(110, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(34, 117);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Comisión:";
            // 
            // AltaRendicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(302, 239);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxComision);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelProximaRendicion2);
            this.Controls.Add(this.labelProximaRendicion1);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSigno1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxEmpresa);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxEmpresa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSigno1;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelProximaRendicion1;
        private System.Windows.Forms.Label labelProximaRendicion2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxComision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}