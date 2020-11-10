using System.Collections.Generic;
using System.Linq;
namespace ejercicio
{
    public class AllForOne : Quirk
    {
        Villano portador;
        public AllForOne(string nombre, float tiempoMin, string consecuencias) : base(nombre, tiempoMin, consecuencias)
        {
        }

        public override bool esPeligroso()
        {
            return portador.Quirk.Any(x=> x.esPeligroso());
        }

        public override float poder()
        {
            return portador.poder();
        }

    }
}