/*
Los libros nos aburren, así que en lugar de una biblioteca, vamos a poner una Peliteca,
 la cual es una clase que tiene una lista de películas (de cada película sabemos nombre, género, año, director).
Permitirle al usuario consultar la Peliteca de la siguiente manera:
Buscar por género.
Buscar por nombre.
Buscar por año.
Buscar por director.
Saber cuantas peliculas hay en total.
Saber cuántas películas de un género en específico hay.

*/
using System;
namespace E6
{
    public class Pelicula
    {
        string nombre;
        string genero;
        int anio;
        string director;

        public Pelicula(string nombre, string genero, int anio, string director)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.anio = anio;
            this.director = director;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public int Anio { get => anio; set => anio = value; }
        public string Director { get => director; set => director = value; }
    }
}