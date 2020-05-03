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
    public class Peliteca
    {
        List<Pelicula> peliteca=new List<Pelicula>();

        public Peliteca()
        {
            peliteca.Add(new Pelicula("IT","Terror","Muschietti","2017"));
            peliteca.Add(new Pelicula("Jurasic Park","Aventura","Spielberg","1993"));
            peliteca.Add(new Pelicula("Indiana Jones","Aventura","Spielberg","1981"));
            peliteca.Add(new Pelicula("El rey león","Familiar","Minkoff","1994"));
   
        }
 
        public void Categoria(string texto)
        {
            switch (texto)
            {
                case "genero":
                    Console.WriteLine("Ingrese el genero");
                    texto=Console.ReadLine();
                    foreach (var item in peliteca)
                    {
                        if(item.Gen()==texto)
                        Console.WriteLine(item.Nom());
                    }
                    break;

                case "nombre":
                    Console.WriteLine("Ingrese el nombre");
                    texto=Console.ReadLine();
                    foreach (var item in peliteca)
                    {
                        if(item.Nom()==texto)
                        Console.WriteLine(item.Nom());
                    }
                    break;
                case "anio":
                    Console.WriteLine("Ingrese el año");
                    texto=Console.ReadLine();
                    foreach (var item in peliteca)
                    {
                        if(item.Año()==texto)
                        Console.WriteLine(item.Nom());
                    }
                    break;
                case "director":
                    Console.WriteLine("Ingrese el director");
                    texto=Console.ReadLine();
                    foreach (var item in peliteca)
                    {
                        if(item.Dir()==texto)
                        Console.WriteLine(item.Nom());
                    }
                    break;
                default:
                    break;
            }
        }
        public int contar()
        {
            return peliteca.Count;
        }
        public int ContarPorGenero(string texto2)
        {
            int cont=0;
            foreach (var item in peliteca)
            {
                if(item.Gen()==texto2)
                cont++;
            }
            return cont;
        }
    }
}