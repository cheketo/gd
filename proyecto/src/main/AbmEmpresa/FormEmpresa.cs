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
    public partial class FormEmpresa : Form
    {

        public Empresa empresa;
        public FormEmpresa()
        {
            InitializeComponent();
            empresa = new Empresa();

            CaragarView();
            
        }

        private void FormEmpresa_Load(object sender, EventArgs e)
        {
            Rubro.CargarComboBox(comboBoxRubro,"Cualquier Rubro");
        }

        public void CaragarView()
        {
            string where="";
            string nombre = textBoxNombre.Text;
            string cuit = textBoxCuit.Text;
            int rubro = 0;
            if(comboBoxRubro.SelectedValue!=null)
            {
                rubro = Convert.ToInt32(comboBoxRubro.SelectedValue.ToString());
                
                if (rubro>0)
                {
                    where = "AND rubro = '" + comboBoxRubro.Text+"'";
                }
            }

            if(nombre!=null && nombre !="")
            {
                where += "AND nombre LIKE '%"+nombre.Trim()+"%'";
            }

            if (cuit != null && cuit !="")
            {
                where += "AND cuit LIKE '%" + cuit.Trim() + "%'";
            }

            empresa.ObtenerListado(dataGridViewEmpresa,where);
            
        }
        
        public void dataGridViewEmpresa_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int idEmpresa = Convert.ToInt32(dataGridViewEmpresa.Rows[e.RowIndex].Cells[2].Value);
                Empresa editarEmpresa = new Empresa(idEmpresa);
                if (e.ColumnIndex == 0)
                {
                    EditarEmpresa formEditar = new EditarEmpresa(editarEmpresa, this);
                    formEditar.Show();
                }

                if (e.ColumnIndex == 1)
                {
                    if (MensajeHelper.MostrarConfirmacion("¿Desea eliminar la empresa " + dataGridViewEmpresa.Rows[e.RowIndex].Cells[3].Value + "?", "Confirmación - Pago Agil FRBA App") == DialogResult.Yes)
                        editarEmpresa.Inhabilitar();
                    CaragarView();
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
            textBoxCuit.Text = "";
            comboBoxRubro.SelectedIndex = 0;
            buttonBuscar_Click(buttonBuscar,new EventArgs());
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            AltaEmpresa nuevo = new AltaEmpresa(this);
            nuevo.MdiParent = this.MdiParent;
            nuevo.Show();
        }

    }
}
