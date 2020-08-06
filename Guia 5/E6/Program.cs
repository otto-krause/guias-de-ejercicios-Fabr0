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
    class Program
    {
        static void Main(string[] args)
        {
            List<Pelicula> peliculas =new List<Pelicula>{};
            peliculas.Add(new Pelicula("Star Wars","Ciencia Ficcion",1978,"George Lucas")); 
            peliculas.Add(new Pelicula("Jurassic Park","Aventura",1995,"Spielberg"));
            peliculas.Add(new Pelicula("Volver al Futuro","Ciencia Ficcion",1985,"Zameticks"));  
          
            Peliteca peliteca =new Peliteca(peliculas);

            Console.WriteLine("Hello World!");
            Console.WriteLine("Ingrese:"
            +"1 para buscar por genero\n"+
            "2 para buscar por nombre\n"+
            "3 para buscar por año\n"+
            "4 para buscar por director\n"+
            "5 para saber cuantas peliculas hay en total\n"+
            "6 para saber cuantas peliculas de un genero especifico hay\n");
            int resp=Int32.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    peliteca.buscarGenero().ForEach(pelicula=> Console.WriteLine(pelicula.Genero+ pelicula.Nombre));
                    break;
                case 2:
                    peliteca.buscarNombre().ForEach(pelicula=> Console.WriteLine(pelicula.Nombre));
                    break;
                case 3:
                    peliteca.buscarAnio().ForEach(pelicula=> Console.WriteLine(pelicula.Anio+ pelicula.Nombre));
                    break;
                case 4:
                    peliteca.buscarDirector().ForEach(pelicula=> Console.WriteLine(pelicula.Director+ pelicula.Nombre));
                    break;
                case 5:
                    Console.WriteLine("Hay "+peliteca.total()+" peliculas en total");
                    break;
                case 6:
                    Console.WriteLine("Ingrese el genero");
                    string texto=Console.ReadLine();
                    Console.WriteLine("Hay "+peliteca.totalGenero(texto)+" peliculas de "+texto);
                    break;
                default:
                    break;
            }
        }
    }
}
