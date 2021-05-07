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
        return 'feli';
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
            string mensajeCifrado = "";

            SqlDataReader resultadosBD;

            resultadosBD = ConsultarBD("select posicion from METODO_CIFRADO where idCifrado =" + idMetodoCifrado);
            
            while (resultadosBD.Read())
            {
                posicion = (int) resultadosBD[0];
            }

            resultadosBD.Close();
            /*
            for (int i = 0; i < mensajeOriginal.Length; i++)
            {
                //1º Para le letra del mensaje original hallamos su posicion
                resultadosBD = ConsultarBD("select idAlfabeto from ALFABETO where letra = '" + mensajeOriginal[i] + "'");
                while (resultadosBD.Read())
                {
                    posicionLetraActual = (int)resultadosBD[0];
                }
                resultadosBD.Close();
                //2º Calcularemos la posicion de la letra que sustituye a la anterior
                posicionLetraNueva = posicionLetraActual + posicion;
                if (posicionLetraNueva > longitudAlfabeto)
                {
                    posicionLetraNueva = posicionLetraNueva - longitudAlfabeto;
                }
                //3º Obtendremos la letra para la posicion obtenida en el punto 2
                resultadosBD = ConsultarBD("select letra from alfabeto where idAlfabeto = " + posicionLetraNueva);
                //4º Concatenaremos laletra cifrada al mensaje cifrado
                while (resultadosBD.Read())
                {
                    mensajeCifrado = mensajeCifrado + resultadosBD[0];
                }
                resultadosBD.Close();
            }
            */
            return "feli";
            
        }
    }
}
