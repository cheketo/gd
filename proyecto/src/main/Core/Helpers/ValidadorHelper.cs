using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool ValidarTextBox(TextBox tb)
        {
            return !String.IsNullOrWhiteSpace(tb.Text);
        }

        public bool ValidarDateTimePicker(DateTimePicker dtp)
        {
            return (dtp.Value.ToString() != "");
        }
    }
}
