using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ManejoFicheros
{
    class Documento
    {
        StreamWriter documento;

        public Documento(string nombre, string texto)
        {
            documento = new StreamWriter(nombre);
            documento.WriteLine(texto);
            documento.Close();
        }


    }
}
