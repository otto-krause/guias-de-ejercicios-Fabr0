/*Crear la clase Consola, con la cual se pueden agregar juegos (digitales) a la su lista de juegos, jugar y revisar puntaje.

*/
using System.Collections.Generic;
namespace E3
{
    public abstract class Consola
    {
       protected List<Juego> juegos;
        protected int puntos;

        protected Consola()
        {
            this.puntos = 0;
        }

        public virtual void Agregar(Juego juego)
        {
            juegos.Add(juego);
        }
        public abstract void Jugar(int horas);
 
        public Juego elMasNuevo()
        {
            int mayor=0;
            Juego jueguito= new Juego("",0,"");
            foreach (var item in juegos)
            {
                if(item.Año>mayor)
                {
                    mayor=item.Año;
                    jueguito=item;
                }
            }
            return jueguito;
        }
        public Juego elMasViejo()
        {
            int menor=juegos[0].Año;
            Juego jueguito= juegos[0];
            foreach (var item in juegos)
            {
                if(item.Año<menor)
                {
                    menor=item.Año;
                    jueguito=item;
                }
            }
            return jueguito;
        }
        public virtual float revisarPuntaje()
        {
            return puntos;
        }
    }
}