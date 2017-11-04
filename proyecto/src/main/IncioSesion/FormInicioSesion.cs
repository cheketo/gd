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
                //Cambia los intentos del usuario a 0
                usuario.ReiniciarIntentos();
                //Muestra el Form principal
                FormPrincipal principal = new FormPrincipal(usuario);
                principal.Show();
                this.Hide();
            }else{
                //Suma un intento
                usuario.SumarIntento();
                //Mensaje de error
                MessageBox.Show("Usuario o Password incorrectos. Por favor, revise la información e intente nuevamente.");
            }
            

        }
    }
}
