using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.Core.Helpers
{
    class FormatoHelper
    {
        private static FormatoHelper instancia;

        private FormatoHelper() { }

        public static FormatoHelper Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new FormatoHelper();
                }

                return instancia;
            }
        }

        public static char getEstadoFormatter(CheckBox cB)
        {
            if (cB.Checked)
            {
                return 'A';
            }
            else
            {
                return 'I';
            }
        }

        public static Boolean setCheckedFromEstado(Char estado)
        {
            if (estado == 'A')
            {
                return true;
            }
                
            else
            {
                return false;
            }
        }
    }
}
