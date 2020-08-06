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
using System.Collections.Generic;
using System.Linq;
namespace E6
{
    public class Peliteca
    {
        List <Pelicula> peliteca =new List<Pelicula>{};

        public Peliteca(List<Pelicula> peliteca)
        {
            this.peliteca = peliteca;
        }
        public int total(){
           return  peliteca.Count;
        }
        public int totalGenero(string genero){
            return peliteca.Where(pelicula=> pelicula.Genero ==genero).Count();
        }
        public  List<Pelicula> buscarGenero(){
            return peliteca.OrderBy(pelicula=> pelicula.Genero).ToList();
        }
         public  List<Pelicula> buscarNombre(){
            return peliteca.OrderBy(pelicula=> pelicula.Nombre).ToList();
        }
         public  List<Pelicula> buscarDirector(){
            return peliteca.OrderBy(pelicula=> pelicula.Director).ToList();
        }
         public  List<Pelicula> buscarAnio(){
            return peliteca.OrderBy(pelicula=> pelicula.Anio).ToList();
        }
    }
}