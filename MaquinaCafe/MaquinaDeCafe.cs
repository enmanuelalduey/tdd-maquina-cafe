
namespace MaquinaCafe
{
    public class MaquinaDeCafe
    {
        private Cafetera cafetera;
        private Vaso vasosPequeno;
        private Vaso vasosMediano;
        private Vaso vasosGrande;
        private Azucarero azucarero;

        public void SetCafetera(Cafetera cafetera)
        {
            this.cafetera = cafetera;
        }

        public Cafetera GetCafetera()
        {
            return cafetera;
        }

        public void SetVasosPequeno(Vaso vaso)
        {
            vasosPequeno = vaso;
        }

        public Vaso GetVasosPequeno()
        {
            return vasosPequeno;
        }

        public void SetVasosMediano(Vaso vaso)
        {
            vasosMediano = vaso;
        }

        public Vaso GetVasosMediano()
        {
            return vasosMediano;
        }

        public void SetVasosGrande(Vaso vaso)
        {
            vasosGrande = vaso;
        }

        public Vaso GetVasosGrande()
        {
            return vasosGrande;
        }

        public void SetAzucarero(Azucarero azucarero)
        {
            this.azucarero = azucarero;
        }

        public Azucarero GetAzucarero()
        {
            return azucarero;
        }

        public Vaso GetTipoDeVaso(string tipoDeVaso)
        {
            switch (tipoDeVaso.ToLower())
            {
                case "pequeno":
                    return vasosPequeno;

                case "mediano":
                    return vasosMediano;

                case "grande":
                    return vasosGrande;

                default:
                    return null;
            }
        }

        public string GetVasoDeCafe(
            Vaso vaso,
            int cantidadVasos,
            int cantidadDeAzucar)
        {
            if (!vaso.HasVasos(cantidadVasos))
            {
                return "No hay Vasos";
            }

            int cantidadCafe = vaso.GetContenido() * cantidadVasos;

            if (!cafetera.HasCafe(cantidadCafe))
            {
                return "No hay Cafe";
            }

            if (!azucarero.HasAzucar(cantidadDeAzucar))
            {
                return "No hay Azucar";
            }

            vaso.GiveVasos(cantidadVasos);
            cafetera.GiveCafe(cantidadCafe);
            azucarero.GiveAzucar(cantidadDeAzucar);

            return "Felicitaciones";
        }
    }
}
