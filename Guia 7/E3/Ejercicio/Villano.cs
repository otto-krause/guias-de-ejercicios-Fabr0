using System.Collections.Generic;

namespace Ejercicio
{
    public interface Villano
    {
        void atacar(List<Habitante> habitantes);
        double fuerza();
    }
}