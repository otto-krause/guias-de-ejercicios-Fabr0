using System.Collections.Generic;
using System.Linq;
namespace ejercicio
{
    public class Villano
    {
        bool roboEnOnce;
        bool trabajo;
        bool leGustaLaPizzaConPiña;
        List<Quirk> quirk;

        public List<Quirk> Quirk { get => quirk; set => quirk = value; }

        public Villano(List<Quirk> quirk, bool roboEnOnce, bool trabajo, bool leGustaLaPizzaConPiña)
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
            return quirk.Any(x=> x.esPeligroso()) && trabajo;
        }
        public float poder()
        {
            return quirk.Sum(x=> x.poder());
        }
    }
}