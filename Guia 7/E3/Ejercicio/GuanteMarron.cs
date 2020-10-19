using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class GuanteMarron : Villano
    {
        double cantMaldades;

        public GuanteMarron(double cantMaldades)
        {
            this.cantMaldades = cantMaldades;
        }

        public void atacar(List<Habitante> habitantes)
        {
            List<Habitante> ricos = habitantes.Where(h => h.esClaseMedia()).ToList();
            ricos.ForEach(h => h.Asaltado());

        }

        public double fuerza()
        {
            return cantMaldades;
        }
    }
}