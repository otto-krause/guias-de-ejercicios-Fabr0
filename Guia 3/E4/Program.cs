using System;
/*
Crear la clase Tragalibros, la cual representa a una persona a la que le gusta mucho leer. Los tragalibros entienden dos mensajes:
 Leer: que recibe un Libro, y lo agrega a su lista de libros leídos, no puede haber repetidos.
 CalcularCI: que se calcula como 5 por la cantidad de libros leída.

Nota: crear la clase libro, con contiene un título y su autor.
*/
namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tragalibros Lisa = new Tragalibros();

            Console.WriteLine("Ingrese un libro");
            string titulo = Console.ReadLine();
            string autor = Console.ReadLine();
            Libro libro = new Libro(titulo, autor);
            Console.WriteLine(Lisa.CalcularCI());
            Lisa.Leer(libro);
            Console.WriteLine(Lisa.CalcularCI());
            Console.WriteLine("Ingrese un libro");
            titulo = Console.ReadLine();
            autor = Console.ReadLine();
            Libro libro1 = new Libro(titulo, autor);
            Lisa.Leer(libro1);
            Console.WriteLine(Lisa.CalcularCI());
        }
    }
}
