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

namespace TemaAccesoDatos
{    
    public partial class Form1 : Form
    {
        DataSet dsProfesores;
        SqlDataAdapter da;
        private int pos;
        private int maxRegistros;

        private void MostrarRegisto(int pos)
        {
            DataRow dRegistro;

            dRegistro = dsProfesores.Tables["Profesores"].Rows[pos];

            ID_textbox.Text = dRegistro["ID"].ToString();
            Nombre_textbox.Text = dRegistro["Nombre"].ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Joshua\\Documents\\GitHub\\test1\\BDs\\AccesoDatos.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);

            con.Open();

            dsProfesores = new DataSet();
            da = new SqlDataAdapter("SELECT * FROM PROFESORES", con);

            pos = 0;            

            da.Fill(dsProfesores, "Profesores");
            maxRegistros = dsProfesores.Tables["Profesores"].Rows.Count;

            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PrimeroButton_Click(object sender, EventArgs e)
        {
            pos = 0;
            MostrarRegisto(pos);
        }

        private void AnteriorButton_Click(object sender, EventArgs e)
        {
            if (pos > 0)
                pos--;
            MostrarRegisto(pos);
        }

        private void SiguienteButton_Click(object sender, EventArgs e)
        {
            if (pos < maxRegistros - 1)
                pos++;
            MostrarRegisto(pos);
        }

        private void UltimoButton_Click(object sender, EventArgs e)
        {
            pos = maxRegistros - 1;
            MostrarRegisto(pos);
        }

        private void AñadirButton_Click(object sender, EventArgs e)
        {
            ID_textbox.Clear();
            Nombre_textbox.Clear();
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            DataRow dRegistro = dsProfesores.Tables["Profesores"].NewRow();
            dRegistro[0] = Convert.ToInt32(ID_textbox.Text);
            dRegistro[1] = Nombre_textbox.Text;
            dsProfesores.Tables["Profesores"].Rows.Add(dRegistro);

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dsProfesores, "Profesores");

            maxRegistros++;
            pos = maxRegistros - 1;
        }
    }
}
