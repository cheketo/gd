using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace PagoAgilFrba
{
    public partial class FormInicioSesion : Form
    {
        
        public FormInicioSesion()
        {
            InitializeComponent();
        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonStartSession_Click(object sender, EventArgs e)
        {
            //byte[] bytes = Encoding.Unicode.GetBytes(textBoxPassword.Text);
            //SHA256Managed hashstring = new SHA256Managed();

            /*byte[] hash = hashstring.ComputeHash(bytes);
            string passwordHash = string.Empty;
            foreach (byte x in hash)
            {
                passwordHash += String.Format("{0:x2}", x);
            }*/
            //string passwordHash;
            //SHA256 mySHA256 = SHA256Managed.Create();
            byte[] byteArray = Encoding.UTF8.GetBytes(textBoxPassword.Text);


            SHA256 mySHA256 = SHA256Managed.Create();
        
            byte[] hashValue = mySHA256.ComputeHash(byteArray);

            System.IO.StreamReader reader = new System.IO.StreamReader(hashValue);
            string text = reader.ReadToEnd();

            MessageBox.Show(textBoxPassword.Text);
            MessageBox.Show(text);
            DataSet prueba = ConexionDB.SeleccionRegistros(new DataSet(), "select * from SQL_86.usuarios WHERE usuario = '"+textBoxUser.Text+"' AND password='"+ hashValue + "'");

            
            if (prueba.Tables[0].Rows.Count>0) //amego
            {
                MessageBox.Show("Se encontró registros");
            }
            else
            {
                MessageBox.Show("0 registros");
            }

        }
    }
}
