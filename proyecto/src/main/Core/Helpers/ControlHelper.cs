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

        public static void SoloNumerosEvento(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void SoloLetrasEvento(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void SetAllCheckBoxRedOnly(Form form, Boolean valor)
        {
            foreach (Control c in form.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).ReadOnly = valor;
            }
        }

        public static void SoloNumerosDecimalEvento(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;

            }
        }
    }
}
