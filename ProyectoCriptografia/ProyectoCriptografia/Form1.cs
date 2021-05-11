using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCriptografia
{
    public partial class Form1 : Form
    {

        public Form1()
        {
          

            InitializeComponent();

           
            cMetodoCifrado.Items.Add("Método de cifrado - Transposición 1");
            cMetodoCifrado.Items.Add("Método de cifrado - Transposición 2");
            cMetodoCifrado.Items.Add("Método de cifrado - Transposición 3");

        }

        public bool validarFormulario ()
        {
            bool formularioCompleto = true;

            if (string.IsNullOrEmpty(cMensajeCifrar.Text) || string.IsNullOrEmpty(cMetodoCifrado.Text))
                formularioCompleto = false;

            return formularioCompleto;

        }

        private void BCifrar_Click(object sender, EventArgs e)
        {
            entornosCifrado clsCifrado;
            int idMetodoCifrado=0;
            SqlDataReader consultaMetodosCifrado;
            String mensajeCifrado="";

            clsCifrado = new entornosCifrado(); 

            if (validarFormulario())
            {

                mensajeCifrado =clsCifrado.cifrarMensaje(cMensajeCifrar.Text, cMetodoCifrado.SelectedIndex);

                MessageBox.Show("El mensaje cifrado es " + mensajeCifrado);

            }
            else
            {
                MessageBox.Show("Complete los campos de formulario antes de Cifrar el mensaje");

            }

        }
    }
}
