using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoCriptografía2021
{
    public class EntornosCifrado
    {
        SqlConnection miConexion;

        public EntornosCifrado()
        {
            miConexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=CRIPTOGRAFIA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            miConexion.Open();
        }
        public SqlDataReader ConsultarBD(string consulta)
        {
            SqlDataReader resultados;
            SqlCommand comando;

            comando = new SqlCommand(consulta, miConexion);

            resultados = comando.ExecuteReader();
            
            return resultados;
        }

        public string cifrarMensaje(string mensajeOriginal, int idMetodoCifrado)
        {
            int posicion = 0;
            int posicionLetraActual = 0;
            int posicionLetraNueva = 0;
            int longitudAlfabeto = 27;
            string mensajeCifrado;

            SqlDataReader resultadosBD;

            resultadosBD = ConsultarBD("select posicion from metodo_cifrado where idCifrado =" + idMetodoCifrado);

            while (resultadosBD.Read())
            {
                posicion = (int) resultadosBD[0];
            }

            for (int i = 0; i < mensajeOriginal.Length; i++)
        }
    }
}
