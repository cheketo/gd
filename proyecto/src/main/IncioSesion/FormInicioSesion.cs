using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using PagoAgilFrba.Core.Helpers;


namespace PagoAgilFrba
{
    public partial class FormInicioSesion : Form
    {
        
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonStartSession_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.SetDatosPorUsuario(textBoxUser.Text);
            string password = ConexionDB.getHashSha256(textBoxPassword.Text);
            if (usuario.ComprobarPassword(password) && usuario.EstaActivo())
            {
                if (usuario.ValidarRol())
                {
                    //Cambia los intentos del usuario a 0
                    usuario.ReiniciarIntentos();
                    if (usuario.CantidadRoles() > 1)
                    {
                        //Muestra el Form de seleccion de roles
                        FormRoles roles = new FormRoles(usuario);
                        roles.Show();
                    }
                    else
                    {
                        //Muestra el Form principal
                        FormPrincipal principal = new FormPrincipal(usuario);
                        principal.Show();
                    }
                    this.Hide();
                }
                else
                {
                    MensajeHelper.MostrarAviso("El usuario puede operar en el sistema debido a que no tiene un rol asociado.", "Pago Agil FRBA App");
                }

            }else{
                //Suma un intento
                usuario.SumarIntento();
                //Mensaje de error
                MensajeHelper.MostrarAviso("Usuario o Password incorrectos. Por favor, revise la información e intente nuevamente.", "Pago Agil FRBA App");
            }
            

        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                buttonStartSession.PerformClick();
            }
        }
    }
}
