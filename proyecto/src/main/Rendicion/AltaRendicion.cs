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
    public partial class AltaRendicion : Form
    {
        public Rendicion obj;
        public Usuario usuario;

        public AltaRendicion(Usuario usuario)
        {
            this.usuario = usuario;
            obj = new Rendicion();
            InitializeComponent();
            Empresa.LlenarComboBox(comboBoxEmpresa);
            if (usuario.TempId > 0)
                comboBoxEmpresa.SelectedValue = usuario.TempId;
        }

        private void AltaRendicion_Load(object sender, EventArgs e)
        {
            OcultarDatosRendicion();
        }

        public void BuscarDatos()
        {
            if (comboBoxEmpresa.SelectedValue != null)
            {
                obj.SetEmpresa(Convert.ToInt32(comboBoxEmpresa.SelectedValue.ToString()));
                obj.ObtenerFacturas();

                if (!obj.ExisteRendicion())
                {
                    MostrarDatosRendicion();
                    maskedTextBoxComision.Text = obj.ObtenerPorcentajeComision();
                    labelFacturas.Text = obj.FacturasARendir.Rows.Count.ToString();
                    labelTotal.Text = obj.ObtenerTotal();
                    labelComision.Text = obj.ObtenerComision(maskedTextBoxComision.Text);
                }
                else
                {
                    OcultarDatosRendicion();
                    MensajeHelper.MostrarAviso("Ya se ha realizado una rendición sobre esta empresa en el mes actual.", "Aviso - Pago Agil FRBA App");
                }
            }
        }

        public void MostrarDatosRendicion()
        {

            labelComision.Show();
            labelTotal.Show();
            labelFacturas.Show();
            maskedTextBoxComision.Show();
            buttonRendir.Show();
            buttonBuscar.Hide();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            label6.Show();
            
        }

        public void OcultarDatosRendicion()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            labelComision.Hide();
            labelTotal.Hide();
            labelFacturas.Hide();
            maskedTextBoxComision.Hide();
            buttonRendir.Hide();
            buttonBuscar.Show();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            
            if (MensajeHelper.MostrarConfirmacion("¿Desea realizar la rendición mensual para la empresa "+comboBoxEmpresa.SelectedText+"?", "Confirmación - Rendicion Agil FRBA App") == DialogResult.Yes)
            {
                obj.Fecha = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                obj.Guardar();
                this.Dispose();
            }
        }        

        public void CalcularImporte()
        {
            decimal importe = 0;
            labelTotal.Text = importe.ToString();
        }

        private void comboBoxCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            OcultarDatosRendicion();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            BuscarDatos();
        }

        private void maskedTextBoxComision_TextChanged(object sender, EventArgs e)
        {
            labelComision.Text = obj.ObtenerComision(maskedTextBoxComision.Text);
        }
    }
}
