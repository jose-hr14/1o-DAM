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
using System.Data;

namespace AccesoDatosEj01
{
    public partial class Form1 : Form
    {
        DataSet dataSetProfes;
        SqlDataAdapter dataAdapterProfes;
        int numRegistro = 0;
        int maxRegistros;
        public Form1()
        {
            InitializeComponent();

            string rutaBD = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Joshua\\Documents\\GitHub\\test1\\AccesoDatosEj01\\AccesoDatosEj01\\Database1.mdf;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(rutaBD);

            conexion.Open();

            dataSetProfes = new DataSet();
            dataAdapterProfes = new SqlDataAdapter("SELECT * FROM Profes", conexion);
            dataAdapterProfes.Fill(dataSetProfes, "Profes");

            maxRegistros = dataSetProfes.Tables["Profes"].Rows.Count;

            conexion.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            textBoxDNI.Clear();
            textBoxNombre.Clear();
            textBoxApellidos.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
        }

        private void buttonGuardarNuevo_Click(object sender, EventArgs e)
        {
            DataRow registro = dataSetProfes.Tables["Profes"].NewRow();
            registro[0] = textBoxDNI.Text;
            registro[1] = textBoxNombre.Text;
            registro[2] = textBoxApellidos.Text;
            registro[3] = textBoxTelefono.Text;
            registro[4] = textBoxEmail.Text;
            dataSetProfes.Tables["Profes"].Rows.Add(registro);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterProfes);
            dataAdapterProfes.Update(dataSetProfes, "Profes");
        }

        private void buttonPrimero_Click(object sender, EventArgs e)
        {
            numRegistro = 0;
            DataRow registro = dataSetProfes.Tables["Profes"].Rows[numRegistro];
            textBoxDNI.Text = registro[0].ToString();
            textBoxNombre.Text = registro[1].ToString(); 
            textBoxApellidos.Text = registro[2].ToString(); 
            textBoxTelefono.Text = registro[3].ToString(); 
            textBoxEmail.Text = registro[4].ToString();
        }

        private void buttonUltimo_Click(object sender, EventArgs e)
        {
            numRegistro = dataSetProfes.Tables["Profes"].Rows.Count;
            numRegistro--;
            DataRow registro = dataSetProfes.Tables["Profes"].Rows[numRegistro];

            textBoxDNI.Text = registro[0].ToString();
            textBoxNombre.Text = registro[1].ToString();
            textBoxApellidos.Text = registro[2].ToString();
            textBoxTelefono.Text = registro[3].ToString();
            textBoxEmail.Text = registro[4].ToString();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            DataRow registro = dataSetProfes.Tables["Profes"].Rows[numRegistro];

            dataSetProfes.Tables["Profes"].Rows.Remove(registro);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterProfes);
            dataAdapterProfes.Update(dataSetProfes, "Profes");

            textBoxDNI.Clear();
            textBoxNombre.Clear();
            textBoxApellidos.Clear();
            textBoxTelefono.Clear();
            textBoxEmail.Clear();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {

            numRegistro++;

            DataRow registro = dataSetProfes.Tables["Profes"].Rows[numRegistro];
            textBoxDNI.Text = registro[0].ToString();
            textBoxNombre.Text = registro[1].ToString();
            textBoxApellidos.Text = registro[2].ToString();
            textBoxTelefono.Text = registro[3].ToString();
            textBoxEmail.Text = registro[4].ToString();
        }

        private void buttonAnterior_Click(object sender, EventArgs e)
        {

        }

        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            DataRow registro = dataSetProfes.Tables["Profes"].Rows[numRegistro];

            registro[0] = textBoxDNI.Text;
            registro[1] = textBoxNombre.Text;
            registro[2] = textBoxApellidos.Text;
            registro[3] = textBoxTelefono.Text;
            registro[4] = textBoxEmail.Text;


            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapterProfes);
            dataAdapterProfes.Update(dataSetProfes, "Profes");

        }
    }
}
