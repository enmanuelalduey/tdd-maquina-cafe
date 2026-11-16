
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class TestMaquinaDeCafe
    {
        private Cafetera cafetera;
        private Vaso vasosPequeno;
        private Vaso vasosMediano;
        private Vaso vasosGrande;
        private Azucarero azucarero;
        private MaquinaDeCafe maquinaDeCafe;

        [TestInitialize]
        public void SetUp()
        {
            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);

            maquinaDeCafe = new MaquinaDeCafe();

            maquinaDeCafe.SetCafetera(cafetera);
            maquinaDeCafe.SetVasosPequeno(vasosPequeno);
            maquinaDeCafe.SetVasosMediano(vasosMediano);
            maquinaDeCafe.SetVasosGrande(vasosGrande);
            maquinaDeCafe.SetAzucarero(azucarero);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");

            Assert.AreEqual(maquinaDeCafe.GetVasosPequeno(), vaso);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("mediano");

            Assert.AreEqual(maquinaDeCafe.GetVasosMediano(), vaso);
        }

        [TestMethod]
        public void DeberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("grande");

            Assert.AreEqual(maquinaDeCafe.GetVasosGrande(), vaso);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");

            string resultado =
                maquinaDeCafe.GetVasoDeCafe(vaso, 10, 2);

            Assert.AreEqual("No hay Vasos", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinaDeCafe.SetCafetera(cafetera);

            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");

            string resultado =
                maquinaDeCafe.GetVasoDeCafe(vaso, 1, 2);

            Assert.AreEqual("No hay Cafe", resultado);
        }

        [TestMethod]
        public void DeberiaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinaDeCafe.SetAzucarero(azucarero);

            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");

            string resultado =
                maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("No hay Azucar", resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafe()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");

            maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            int resultado =
                maquinaDeCafe.GetCafetera().GetCantidadCafe();

            Assert.AreEqual(40, resultado);
        }

        [TestMethod]
        public void DeberiaRestarVaso()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");

            maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            int resultado =
                maquinaDeCafe.GetVasosPequeno().GetCantidadVasos();

            Assert.AreEqual(4, resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucar()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");

            maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            int resultado =
                maquinaDeCafe.GetAzucarero().GetCantidadAzucar();

            Assert.AreEqual(17, resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquinaDeCafe.GetTipoDeVaso("pequeno");

            string resultado =
                maquinaDeCafe.GetVasoDeCafe(vaso, 1, 3);

            Assert.AreEqual("Felicitaciones", resultado);
        }
    }
}
