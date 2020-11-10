namespace Ejercicio
{
    public class Villano
    {
        bool roboEnOnce;
        bool trabajo;
        bool leGustaLaPizzaConPiña;
        Quirk quirk;
        public Villano(Quirk quirk, bool roboEnOnce, bool trabajo, bool leGustaLaPizzaConPiña)
        {
            this.quirk = quirk;
            this.roboEnOnce = roboEnOnce;
            this.trabajo = trabajo;
            this.leGustaLaPizzaConPiña = leGustaLaPizzaConPiña;
        }

        public bool esMuyMalo()
        {
            return roboEnOnce && !trabajo && !leGustaLaPizzaConPiña;
        }
        public bool algunaVezFueBueno()
        {
            return !quirk.esPeligroso() && trabajo;
        }
        public float poder()
        {
            return quirk.poder();
        }
    }
}