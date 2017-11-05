using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.AbmCliente;

namespace PagoAgilFrba.Core.Helpers
{
    class ValidadorHelper
    {
        private static ValidadorHelper instancia;

        private ValidadorHelper() { }

        public static ValidadorHelper Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new ValidadorHelper();
                }

                return instancia;
            }
        }

        private static bool IsCampoValido(Control c)
        {
            if(c is TextBox)
            {
                return ValidarTextBox(((TextBox)c));
            }

            return true;
        }

        public static bool ValidarTextBox(TextBox tb)
        {
            return !String.IsNullOrWhiteSpace(tb.Text);
        }

        public static Boolean ValidarAllCampos(Form form)
        {
            foreach (Control c in form.Controls)
            {
                if(!IsCampoValido(c))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ValidarDateTimePicker(DateTimePicker dtp)
        {
            return (dtp.Value.ToString() != "");
        }

    }
}
