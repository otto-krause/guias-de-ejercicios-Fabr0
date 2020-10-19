using System.Collections.Generic;
namespace Ejercicio
{
    public class Psicopata : Villano
    {
        int asesinatos;
        int inteligencia;

        public Psicopata(int asesinatos, int inteligencia)
        {
            this.asesinatos = asesinatos;
            this.inteligencia = inteligencia;
        }

        public void atacar(List<Habitante> habitantes)
        {
            habitantes.RemoveRange(0,5);
            asesinatos+=5;
        }

        public double fuerza()
        {
            return inteligencia*asesinatos;
        }
    }
}