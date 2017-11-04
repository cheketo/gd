using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Core.Helpers
{
    public class MensajeHelper
    {
        private static MensajeHelper instancia;

        private MensajeHelper() { }

        public static MensajeHelper Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new MensajeHelper();
                }

                return instancia;
            }
        }

        public static void MostrarError(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static DialogResult MostrarConfirmacion(string mensaje, string titulo)
        {
            return MessageBox.Show(mensaje, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void MostrarAviso(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void MostrarWarning(string mensaje, string titulo)
        {
            MessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
