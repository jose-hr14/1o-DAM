using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionAlumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CGrupo.Items.Add("1º O");
            CGrupo.Items.Add("1º M");
            CGrupo.Items.Add("1º N");
            CGrupo.Items.Add("1º L");
            CGrupo.Items.Add("1º K");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alumno miAlumno;

            miAlumno = new Alumno(CNombre.Text, CApellidos.Text, Convert.ToDateTime(CFechaNacimiento.Text), CGrupo.SelectedItem.ToString());

            CNombre.Text = "";
            CApellidos.Text = "";
            CFechaNacimiento.Text = "";

            cListaAlumnos.AppendText("Alumno " + miAlumno.nombre + " " + miAlumno.apellidos +
                ". Nacido el " + miAlumno.fechanacimiento + ", del grupo " +
                miAlumno.grupo + "." + "\n");
        }
    }
}
