namespace PagoAgilFrba
{
    partial class FormInicioSesion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.buttonStartSession = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(90, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(82, 13);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "Inicio de Sesion";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStartSession
            // 
            this.buttonStartSession.Location = new System.Drawing.Point(82, 202);
            this.buttonStartSession.Name = "buttonStartSession";
            this.buttonStartSession.Size = new System.Drawing.Size(115, 21);
            this.buttonStartSession.TabIndex = 3;
            this.buttonStartSession.Text = "Iniciar Sesión";
            this.buttonStartSession.UseVisualStyleBackColor = true;
            this.buttonStartSession.Click += new System.EventHandler(this.buttonStartSession_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(133, 69);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(114, 20);
            this.textBoxUser.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(133, 113);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(114, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(43, 72);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 1;
            this.labelUsuario.Text = "Usuario";
            this.labelUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(33, 113);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 0;
            this.labelPassword.Text = "Password";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.buttonStartSession);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormInicioSesion";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormInicioSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button buttonStartSession;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPassword;
    }
}

