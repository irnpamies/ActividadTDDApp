using Microsoft.VisualStudio.TestTools.UnitTesting;
using ActividadTDDApp;

namespace TestActividadTDDApp
{
    [TestClass]
    public sealed class FuncionesTest
    {
        //Factorial

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

        //Contraseña

        [TestMethod]
        public void EsContrasenyaValida_NullOVacia_RetornaFalse()
        {
            // Regla: No null, no vacía
            Assert.IsFalse(Funciones.EsContrasenyaValida(null));
            Assert.IsFalse(Funciones.EsContrasenyaValida(""));
        }

        [TestMethod]
        public void EsContrasenyaValida_LongitudMenorA8_RetornaFalse()
        {
            // Regla: Tener una longitud de 8 o más caracteres
            Assert.IsFalse(Funciones.EsContrasenyaValida("Abc#12")); // 6 caracteres
        }

        [TestMethod]
        public void EsContrasenyaValida_SinCaracterAlmohadilla_RetornaFalse()
        {
            // Regla: Debe contener el carácter #
            Assert.IsFalse(Funciones.EsContrasenyaValida("Password1234")); // 12 caracteres sin #
        }

        [TestMethod]
        public void EsContrasenyaValida_CumpleTodosLosRequisitos_RetornaTrue()
        {
            // Regla: >= 8 caracteres y contiene '#'
            Assert.IsTrue(Funciones.EsContrasenyaValida("Clave#Segura1"));
        }
    }
}