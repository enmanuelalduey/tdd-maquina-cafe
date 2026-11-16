
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class TestAzucarero
    {
        private Azucarero azucarero;

        [TestInitialize]
        public void SetUp()
        {
            azucarero = new Azucarero(10);
        }

        [TestMethod]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucar()
        {
            bool resultado = azucarero.HasAzucar(5);
            Assert.AreEqual(true, resultado);

            resultado = azucarero.HasAzucar(10);
            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoPorqueNoHaySuficienteAzucar()
        {
            bool resultado = azucarero.HasAzucar(15);
            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucarAlAzucarero()
        {
            azucarero.GiveAzucar(5);
            Assert.AreEqual(5, azucarero.GetCantidadAzucar());

            azucarero.GiveAzucar(2);
            Assert.AreEqual(3, azucarero.GetCantidadAzucar());
        }
    }
}
