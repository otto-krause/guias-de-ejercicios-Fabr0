using System;
using System.Collections.Generic;
/*4) Los libros nos aburren, así que en lugar de una biblioteca, vamos a poner una Peliteca, 
la cual es una clase que tiene una lista de películas (de cada película sabemos nombre, género, año, director).
Permitirle al usuario consultar la Peliteca de la siguiente manera:
Buscar por género.
Buscar por nombre.
Buscar por año.
Buscar por director.
Saber cuantas peliculas hay en total.
Saber cuántas películas de un género en específico hay.

Nota: Investigar sobre métodos de cadenas (strings). No imprimir mensajes de consola desde una clase que no sea la Program.
*/
namespace E4
{
    public class Pelicula
    {
        string nombre;
        string genero;
        string director;
        string anio;

        public Pelicula(string nombre,string genero,string director,string anio)
        {
            this.nombre=nombre;
            this.genero=genero;
            this.director=director;
            this.anio=anio;
        }
        public string Gen()
        {
            return this.genero;
        }
        public string Nom()
        {
            return this.nombre;
        }
        public string Año()
        {
            return this.anio;
        }
        public string Dir()
        {
            return this.director;
        }

    }
}