using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class GuanteBlanco : Villano
    {
        double cantMaldades;

        public GuanteBlanco()
        {
            this.cantMaldades = 5;
        }

        public void atacar(List<Habitante> habitantes)
        {
            cantMaldades++;
            List<Habitante> ricos = habitantes.Where(h=> h.esClaseAlta()).ToList();
            ricos.ForEach(h=> h.Asaltado());


        }

        public double fuerza()
        {
            return  cantMaldades;
        }
    }
}