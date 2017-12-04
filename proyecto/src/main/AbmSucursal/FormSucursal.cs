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

namespace PagoAgilFrba
{
    public partial class FormSucursal : Form
    {

        public Sucursal sucursal;
        public FormSucursal()
        {
            InitializeComponent();
            sucursal = new Sucursal();
            
        }

        private void FormSucursal_Load(object sender, EventArgs e)
        {
            Sucursal.CargarComboEstado(comboBoxEstado);
            CaragarView();
        }

        public void CaragarView()
        {
            bool edit = true;
            bool delete = true;
            bool activate = false;
            string where="";
            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;
            string cp = textBoxCp.Text;
            int estado = 1;
            if (comboBoxEstado.SelectedValue!=null)
            {
                estado = Convert.ToInt32(comboBoxEstado.SelectedValue.ToString());
            }
            if (estado != 2)
            {
                where += "AND estado = 'Activo'";
                delete = true;
                activate = false;
            }
            else
            {
                where += "AND estado = 'Inactivo'";
                delete = false;
                activate = true;
            }


            if (nombre!=null && nombre !="")
            {
                where += "AND nombre LIKE '%"+nombre.Trim()+"%'";
            }

            if (direccion != null && direccion !="")
            {
                where += "AND direccion LIKE '%" + direccion.Trim() + "%'";
            }

            if (cp != null && cp != "")
            {
                where += "AND Codigo_Postal LIKE '%" + cp.Trim() + "%'";
            }

            sucursal.ObtenerListado(dataGridView,where,"*",edit,delete,activate);
            
        }
        
        public void dataGridView_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                Sucursal obj = new Sucursal(id);
                switch (e.ColumnIndex)
                {
                    case 0:
                        if (MensajeHelper.MostrarConfirmacion("¿Desea inhabilitar la sucursal " + dataGridView.Rows[e.RowIndex].Cells[5].Value + "?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                        {
                            obj.CambiarEstado("I");
                            CaragarView();
                        }
                        break;
                    case 1:
                        if (MensajeHelper.MostrarConfirmacion("¿Desea activar la sucursal " + dataGridView.Rows[e.RowIndex].Cells[5].Value + "?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                        {
                            obj.CambiarEstado("A");
                            CaragarView();
                        }
                        break;
                    case 2:
                        EditarSucursal formEditar = new EditarSucursal(obj, this);
                        formEditar.Show();
                        break;
                }
            }
        }


        public void buttonBuscar_Click(object sender, EventArgs e)
        {
            CaragarView();
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Text = "";
            textBoxDireccion.Text = "";
            textBoxCp.Text = "";
            comboBoxEstado.SelectedValue = 1;
            buttonBuscar_Click(buttonBuscar,new EventArgs());
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            AltaSucursal nuevo = new AltaSucursal(this);
            nuevo.Show();
        }
    }
}
