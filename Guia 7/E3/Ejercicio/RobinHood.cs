using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class RobinHood : Villano
    {
    
        double cantMaldades;

        public RobinHood(double cantMaldades)
        {
            this.cantMaldades = cantMaldades;
        }

        public void atacar(List<Habitante> habitantes)
        {
            cantMaldades++;
            List<Habitante> ricos = habitantes.Where(h => h.esClaseAlta()).ToList();
           
            double dineroRobado = ricos.Sum(x=> x.Robado());
           
            List<Habitante> pobres = habitantes.Where(h => h.esClaseBaja()).ToList();
           
            int cant= pobres.Count;
            pobres.ForEach(p => p.Adquirido(dineroRobado / cant));
           
            ricos.ForEach(h => h.Asaltado());


        }

        public double fuerza()
        {
            return cantMaldades;
        }
    }
}