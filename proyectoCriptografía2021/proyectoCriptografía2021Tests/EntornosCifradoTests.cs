using Microsoft.VisualStudio.TestTools.UnitTesting;
using proyectoCriptografía2021;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using proyectoCriptografía2021;

namespace proyectoCriptografía2021.Tests
{
    [TestClass()]
    public class EntornosCifradoTests
    {
        [TestMethod()]
        public void PruebaUnitariaCifrarMensaje()
        {
            EntornosCifrado claseprueba;

            claseprueba = new EntornosCifrado();

            Assert.AreEqual(claseprueba.cifrarMensaje("kk", 1), "Error metodoCifrar");
        }
    }
}