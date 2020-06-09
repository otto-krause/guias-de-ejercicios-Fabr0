using System.Collections.Generic;
namespace E3
{
    /*
    Crear la clase Jugador, que tiene un nombre y una lista de consolas.
Crear en Jugador el método adquirirJuego, que recibe un juego y lo guarda en su respectiva consola.
Crear en Jugador el método laMasUsada, que devuelve cuál fue la consola con la que obtuvo mayor puntaje.
*/
    public class Jugador
    {
        string nombre;
        List<Consola> consolas;

        public Jugador(string nombre, List<Consola> consolas)
        {
            this.nombre = nombre;
            this.consolas = consolas;
        }

        public void adquirirJuego(Juego juego)
        {
            foreach (var item in consolas)
            {
                if(item.ToString()==juego.Consola)
                item.Agregar(juego);
            }
        }
        public Consola laMasUsada()
        {
            Consola consola=consolas[0];
            float mayor=consolas[0].revisarPuntaje();
            foreach (var item in consolas)
            {
                if(item.revisarPuntaje()>mayor)
                {
                    mayor=item.revisarPuntaje();
                    consola=item;
                }
            }
            return consola;
        }
    }
}