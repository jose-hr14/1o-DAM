using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCriptografia
{
    public class entornosCifrado
    {
        // Propiedad privada donde almacenaremos la cadena de conexión
        private SqlConnection miConexion;

        // Propiedad privada donde almacenaremos la longitud de nuestro alfabeto
        private int longitudAlfabeto;
        public String alfabeto;

        public entornosCifrado()
        {

            miConexion = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog='CRIPTOGRAFIA';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            //miConexion.Open(); // Abrimos la conexion
            longitudAlfabeto = 27;
            alfabeto = "abcdefghijklmnñopqrstuvwxyz";
        }


        public int obtenerPosicion(String letra)
        {

            int posicion=0;

            for (int i = 0; i < alfabeto.Length; i++)
            {
                if (alfabeto[i].Equals(letra)) 
                    posicion = i;
            }

            return posicion;
        }

        public string obtenerLetraPosicion(int posicion)
        {

            string letra;
            letra = alfabeto[posicion].ToString(); 
            return letra;
        }

        public String cifrarMensaje(String mensajeOriginal, int idMetodoCifrado)
        {
            String mensajeCifrado = "";
            int posicion = idMetodoCifrado;
            SqlDataReader consultaBD;
            int posicionLetra = 0;
            int nuevaPosicionLetra = 0;
         

            for (int i = 0; i < mensajeOriginal.Length; i++)
            {

                // Obtener posicion de la letra dentro 
                //del alfabeto 
                posicionLetra = obtenerPosicion(mensajeOriginal[i].ToString());

                nuevaPosicionLetra = posicionLetra + posicion;

                if (nuevaPosicionLetra > longitudAlfabeto)
                {
                    nuevaPosicionLetra = nuevaPosicionLetra - longitudAlfabeto;

                }

                mensajeCifrado = mensajeCifrado + obtenerLetraPosicion(nuevaPosicionLetra);
            }

            return mensajeCifrado;


        }

        /*  public SqlDataReader obtenerMetodosCifrado()
         {
             //Obtener de la base de datos  nombre de la tabla METODO_CIFRADO 

            SqlDataReader rMetodosCifrado;

             rMetodosCifrado = consultarBD("select nombre from METODO_CIFRADO");

             return rMetodosCifrado;


         }*/



        public String desCifrarMensaje(int idMensaje)
        {
            String mensajeDescifrado = "";

            return mensajeDescifrado; 

        }

    }
}
