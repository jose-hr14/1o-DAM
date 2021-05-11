using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProyectoCriptografia;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            entornosCifrado eCifrado = new entornosCifrado();

            string mensajeOriginal = "hola";
            string mensajeTeorico = "gpfd";
            string mensajeReal = "";

            mensajeReal = eCifrado.cifrarMensaje(mensajeOriginal, 1);

            Assert.AreEqual(mensajeTeorico, mensajeReal);
        }
    }
}
