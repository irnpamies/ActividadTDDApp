using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        public void CalcularFactorial_NumeroNegativo_RetornaMenosUno()
        {
            // Regla: Si n < 0 retorna -1
            long resultado = Funciones.CalcularFactorial(-5);
            Assert.AreEqual(-1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_Cero_RetornaUno()
        {
            // Regla: 0! = 1
            long resultado = Funciones.CalcularFactorial(0);
            Assert.AreEqual(1, resultado);
        }

        [TestMethod]
        public void CalcularFactorial_NumeroPositivo_RetornaCalculoCorrecto()
        {
            // Regla: 5! = 120
            long resultado = Funciones.CalcularFactorial(5);
            Assert.AreEqual(120, resultado);
        }
    }
}