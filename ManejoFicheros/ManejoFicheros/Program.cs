using System;
using System.IO;

namespace ManejoFicheros
{
    class Program
    {
        struct tipoFicha
        {
            public string nombreFich;
            public long tamanyo;
        }
        public static void Fichas()
        {
            tipoFicha[] fichas   // Los datos en si
                = new tipoFicha[1000];
            int numeroFichas = 0;  // Número de fichas que ya tenemos
            int i;               // Para bucles
            int opcion;          // La opcion del menu que elija el usuario
            string textoBuscar;  // Para cuando preguntemos al usuario
            long tamanyoBuscar;  // Para buscar por tamaño


            do
            {
                // Menu principal, repetitivo
                Console.WriteLine();
                Console.WriteLine("Escoja una opción:");
                Console.WriteLine("1.- Añadir datos de un nuevo fichero");
                Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
                Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
                Console.WriteLine("4.- Ver datos de un fichero");
                Console.WriteLine("5.- Salir");

                opcion = Convert.ToInt32(Console.ReadLine());

                // Hacemos una cosa u otra según la opción escogida
                switch (opcion)
                {

                    case 1: // Añadir un dato nuevo
                        if (numeroFichas < 1000)
                        {  // Si queda hueco
                            Console.WriteLine("Introduce el nombre del fichero: ");
                            string nombre = Console.ReadLine();
                            StreamWriter documento = new StreamWriter(nombre + ".txt");
                            Console.WriteLine("Introduce texto: ");
                            string texto = Console.ReadLine();
                            documento.WriteLine(texto);
                            documento.Close();
                            // Y ya tenemos una ficha más
                            numeroFichas++;
                        }
                        else   // Si no hay hueco para más fichas, avisamos
                            Console.WriteLine("Máximo de fichas alcanzado (1000)!");
                        break;

                    case 2: // Mostrar todos
                        for (i = 0; i < numeroFichas; i++)
                            Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                                numeroFichas.ToString() + ".txt", fichas[i].tamanyo);
                        break;

                    case 3: // Mostrar según el tamaño
                        Console.WriteLine("¿A partir de que tamaño quieres ver?");
                        tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
                        for (i = 0; i < numeroFichas; i++)
                            if (fichas[i].tamanyo >= tamanyoBuscar)
                                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                                    fichas[i].nombreFich, fichas[i].tamanyo);
                        break;

                    case 4: // Ver todos los datos (pocos) de un fichero
                        Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
                        textoBuscar = Console.ReadLine();
                        for (i = 0; i < numeroFichas; i++)
                            if (fichas[i].nombreFich == textoBuscar)
                                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                                    fichas[i].nombreFich, fichas[i].tamanyo);
                        break;

                    case 5: // Salir: avisamos de que salimos */
                        Console.WriteLine("Fin del programa");
                        break;

                    default: // Otra opcion: no válida
                        Console.WriteLine("Opción desconocida!");
                        break;
                }
            } while (opcion != 5);  // Si la opcion es 5, terminamos
        }
        
        public static void EscribirFichero()
        {
            StreamWriter documento = new StreamWriter("doc.txt");
            documento.WriteLine("Este es un documento de prueba");
            documento.WriteLine("Probando a crear un programa que escriba en ficheros");
            documento.Close();
        }
        public static void Ej811()
        {
            StreamWriter documento = new StreamWriter("doc811.txt");
            string texto = "";
            Console.WriteLine("Introduce texto o escribe fin para salir");
            do
            {
                texto = Console.ReadLine();
                documento.WriteLine(texto);
            } while (texto != "fin");
            documento.Close();
        }
        static void Main(string[] args)
        {
            Documento doc = new Documento("documento1.txt", "aqui va el texto del documento1");
            ListaDeDocumentos ListaDocs = new ListaDeDocumentos(5);
            ListaDocs.MeterDoc(doc, 0);
        }
    }
}
