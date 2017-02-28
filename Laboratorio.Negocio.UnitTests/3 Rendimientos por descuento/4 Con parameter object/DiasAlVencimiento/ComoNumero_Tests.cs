using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Negocio.RendimientosPorDescuento.ConParameterObject;

namespace Negocio.UnitTests.RendimientosPorDescuento_Tests.ConParameterObject.DiasAlVencimiento_Tests
{
    [TestClass]
    public class ComoNumero_Tests
    {
        decimal elResultadoEsperado;
        decimal elResultadoObtenido;

        [TestMethod]
        public void ComoNumero_CasoUnico_LaFormula()
        {
            elResultadoEsperado = 221;

            elResultadoObtenido = new DiasAlVencimiento(new DateTime(2016, 10, 10), new DateTime(2016, 3, 3)).ComoNumero();

            Assert.AreEqual(elResultadoEsperado, elResultadoObtenido);
        }
    }
}