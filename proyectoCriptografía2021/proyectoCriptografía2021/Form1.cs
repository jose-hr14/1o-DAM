using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
