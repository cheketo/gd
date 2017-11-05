using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagoAgilFrba.Core.Helpers;

namespace PagoAgilFrba.AbmCliente
{
    public partial class VerAbmCliente : Form
    {
        string nombre;
        string apellido;
        string dni;
 
        public VerAbmCliente()
        {
            InitializeComponent();
        }

        private void VerAbmCliente_Load(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            nombre = tBNombre.Text;
            apellido = tBApellido.Text;
            dni = tBDNI.Text;

            var clientes = new Cliente().FindByParametersLike(dni, apellido, nombre);
            dGVClientes.DataSource = clientes;
            dGVClientes.Columns["Id"].Visible = false;
            dGVClientes.Columns["FechaNacimiento"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void dGVClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dGVClientes.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            Cliente cliente = new Cliente().FindOneByID(int.Parse(id));
            var form = new AltaAbmCliente(cliente);
            form.Show();
        }
    }
}
