using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace proyectoCriptografía2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = cMensajeCifrado.Text;
            EntornosCifrado MensajeCifrado = new EntornosCifrado();
            MensajeCifrado.cifrarMensaje(mensaje, 1);
            
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            cMensajeCifrado.Text = "";
        }

        private void cMetodoCifrado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // En el campo este vamos a aladir los metodos de cifrado existentes en la tabla METODOS_CIFRADO
            EntornosCifrado miDesplegable;
            SqlDataReader miConsulta;

            miDesplegable = new EntornosCifrado();

            miConsulta = miDesplegable.ConsultarBD("select idCifrado, cMetodoCifrado from METODOS_CIFRADO");

            while (miConsulta.Read())
            {
                cMetodoCifrado.Text = (string) miConsulta[1];
            }

        }
    }
}
