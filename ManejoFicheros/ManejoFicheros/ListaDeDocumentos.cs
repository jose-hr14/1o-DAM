using System;
using System.Collections.Generic;
using System.Text;

namespace ManejoFicheros
{
    class ListaDeDocumentos
    {
        Documento[] listaDocumentos;

        public ListaDeDocumentos(int numeroDocumentos)
        {
            listaDocumentos = new Documento[numeroDocumentos];
        }
        public void MeterDoc(Documento doc, int indice)
        {
            listaDocumentos[indice] = doc;
        }
    }
}
