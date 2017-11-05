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

            CaragarView();
            
        }

        private void FormSucursal_Load(object sender, EventArgs e)
        {
            Sucursal.CargarComboEstado(comboBoxEstado);
        }

        public void CaragarView()
        {
            string where="";
            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;
            string cp = textBoxCp.Text;
            int estado = 1;
            if (comboBoxEstado.SelectedValue!=null)
            {
                estado = Convert.ToInt32(comboBoxEstado.SelectedValue.ToString());
            }
                
            //MessageBox.Show("Estado: " + estado);
            if (estado!=2)
                where += "AND estado = 'Activo'";
            else
                where += "AND estado = 'Inactivo'";


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

            sucursal.ObtenerListado(dataGridView,where);
            
        }
        
        public void dataGridView_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[2].Value);
            Sucursal editar = new Sucursal(id);
            if (e.ColumnIndex==0)
            { 
                EditarSucursal formEditar = new EditarSucursal(editar, this);
                formEditar.Show();
            }

            if (e.ColumnIndex == 1)
            {
                if(MensajeHelper.MostrarConfirmacion("¿Desea inhabilitar la sucursal " + dataGridView.Rows[e.RowIndex].Cells[3].Value + "?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                    editar.Inhabilitar();
                    CaragarView();
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
            //nuevo.MdiParent = this;
            nuevo.Show();
        }



        //private void dataGridViewEmpresa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //dataGridViewEmpresa.DataSource = ((FormPrincipal)MdiParent).usuario.ObtenerRoles();
        //}
    }
}
