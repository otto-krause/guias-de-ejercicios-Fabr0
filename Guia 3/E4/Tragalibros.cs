using System;

using System.Collections.Generic;
/*
Crear la clase Tragalibros, la cual representa a una persona a la que le gusta mucho leer. Los tragalibros entienden dos mensajes:
 Leer: que recibe un Libro, y lo agrega a su lista de libros leídos, no puede haber repetidos.
 CalcularCI: que se calcula como 5 por la cantidad de libros leída.

Nota: crear la clase libro, con contiene un título y su autor.
*/
namespace E4
{
    public class Tragalibros
    {
        List<Libro> librosLeidos=new List<Libro>{new Libro("Un mago de Terramar","Ursula K. Le Guin"),new Libro("Las tumbas de Atuan","Ursula K. Le Guin")};

        public Tragalibros()
        {
        }

        public void Leer(Libro libro)
        {
          bool texto=false;
          foreach (var item in librosLeidos)
          {
              if(libro.Titulo==item.Titulo)
              texto=true;
          }
          if(!texto)
          librosLeidos.Add(libro);  
        }

        public int CalcularCI()
        {
            return 5*librosLeidos.Count;
        }
    }
}