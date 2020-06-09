/*
Crear la clase Juego, que tiene un nombre, año de lanzamiento y el nombre de la consola en la que puede jugarse.
*/

namespace E3
{
    public class Juego
    {
        string nombre;
        int año;
        string consola;


        public Juego(string nombre, int año, string consola)
        {
            this.nombre = nombre;
            this.Año = año;
            this.Consola = consola;
        }
        
        public int Año { get => año; set => año = value; }
        public string Consola { get => consola; set => consola = value; }
    }
}