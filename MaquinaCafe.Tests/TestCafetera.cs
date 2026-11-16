
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class TestCafetera
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(5);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(11);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafeALaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);

            cafetera.GiveCafe(7);

            Assert.AreEqual(3, cafetera.GetCantidadCafe());
        }
    }
}
