using System.Collections.Generic;

namespace Ejercicio
{
    public class Extraterrestre : Villano
    {
        int abducidos;
        int extremidades;
        int cantidadAbducidos;

        public Extraterrestre(int abducidos, int extremidades, int cantidadAbducidos)
        {
            this.abducidos = abducidos;
            this.extremidades = extremidades;
            this.cantidadAbducidos = cantidadAbducidos;
        }

        public void atacar(List<Habitante> habitantes)//shift+alt+f
        {
            Habitante lemur = new Habitante(2000000);

            habitantes.RemoveRange(0, abducidos);
            for (int i = 0; i < abducidos; i++)
            {
                habitantes.Add(lemur);
            }
            cantidadAbducidos+=abducidos;
        }

        public double fuerza()
        {
            return abducidos / extremidades;
        }
    }
}