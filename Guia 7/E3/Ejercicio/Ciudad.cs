using System.Linq;
using System.Collections.Generic;
namespace Ejercicio
{
    public class Ciudad
    {

        List<Habitante> habitantes;
        List<Villano> villanos;

        public Ciudad(List<Habitante> habitantes, List<Villano> villanos)
        {
            this.habitantes = habitantes;
            this.villanos = villanos;
        }
        public bool esLujosa()
        {
            return habitantes.Count(h => h.esClaseAlta()) > habitantes.Count / 2;
        }
        public void realizarMaldades()
        {
            villanos.ForEach(x=> x.atacar(habitantes));
        }
        public List<Habitante> sonLosMasTop()
        {
            return habitantes.OrderBy(x=> x.Dinero).Take(5).ToList(); //take devuelve x cantudad de elementos
         
        }
    }
}