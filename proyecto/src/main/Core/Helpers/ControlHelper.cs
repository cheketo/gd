using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Core.Helpers
{
    class ControlHelper
    {

        private static ControlHelper instancia;

        private ControlHelper() { }

        public static ControlHelper Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ControlHelper();
                }

                return instancia;
            }
        }

        public static void CerrarApp()
        {
            if (MensajeHelper.MostrarConfirmacion("¿Desea salir de PagoAgil?", "PagoAgil FRBA App") == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public static void CerrarSesionApp()
        {
            if (MensajeHelper.MostrarConfirmacion("¿Desea cerrar la sesión?", "PagoAgil FRBA App") == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        public static void SolotNumerosEvento(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
