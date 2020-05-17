using System;
/*
Crear la clase Tragalibros, la cual representa a una persona a la que le gusta mucho leer. Los tragalibros entienden dos mensajes:
 Leer: que recibe un Libro, y lo agrega a su lista de libros leídos, no puede haber repetidos.
 CalcularCI: que se calcula como 5 por la cantidad de libros leída.

Nota: crear la clase libro, con contiene un título y su autor.
*/
namespace E4
{
    public class Libro
    {
        string titulo;
        string autor;

        public Libro(string titulo, string autor)
        {
            this.Titulo = titulo;
            this.autor = autor;
        }

        public string Titulo { get => titulo; set => titulo = value; }
    }
}