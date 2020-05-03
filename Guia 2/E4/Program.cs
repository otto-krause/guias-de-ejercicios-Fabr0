using System;
using System.Collections.Generic;
/*4) Los libros nos aburren, así que en lugar de una biblioteca, vamos a poner una blockbuster, 
la cual es una clase que tiene una lista de películas (de cada película sabemos nombre, género, año, director).
Permitirle al usuario consultar la blockbuster de la siguiente manera:
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
    class Program
    {
        static void Main(string[] args)
        {
            
            Peliteca blockbuster=new Peliteca();
            Console.WriteLine("¿Por que categoria quiere buscar su pelicula?");
            string texto= Console.ReadLine();
            blockbuster.Categoria(texto);
            Console.WriteLine("Ingrese un genero para saber cuantas peliculas hay de ese genero");
            string texto2= Console.ReadLine();
            Console.WriteLine("Hay "+blockbuster.ContarPorGenero(texto2)+" de ese genero");
        
           
        }
    }
}
