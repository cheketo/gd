using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba
{
    public partial class FormRoles : Form
    {
        private Usuario usuario;

        public FormRoles(Usuario usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        private void FormRoles_Load(object sender, EventArgs e)
        {
            Dictionary<int, string> valoresCombo = new Dictionary<int, string>();
            foreach (DataRow row in this.usuario.ObtenerRoles().Rows)
            {
                valoresCombo.Add(Convert.ToInt32(row[0]), row[1].ToString());
            }
            comboBoxRoles.DisplayMember = "Value";
            comboBoxRoles.ValueMember = "Key";
            comboBoxRoles.DataSource = valoresCombo.ToArray();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            usuario.DeterminarRol(Convert.ToInt32(comboBoxRoles.SelectedValue.ToString()));
            FormPrincipal principal = new FormPrincipal(this.usuario);
            principal.Show();
            this.Hide();
        }
    }
}
