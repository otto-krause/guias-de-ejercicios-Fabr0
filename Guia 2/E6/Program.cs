using System;
using System.Collections.Generic;
/*6) Steam es una plataforma para comprar juegos en línea, Valve no pidió ayuda para volver a recrear una de sus funcionalidades,
 usando el paradigma orientado a objetos. Según nos contaron, necesitan:
Crear la clase juego, que contiene el título del juego, su género y una lista de calificaciones.
Cada calificación está formada por un valor numérico (del 1 al 5) y un comentario, por ejemplo: 
	Estrellas: 2	Reseña: “Es malísimo, se tilda todo el tiempo”
	Estrellas: 5	Reseña: “Buenardo”
Crear la clase steam, que permite buscar los juegos por genero o por calificación (alta: mayor o igual a 4 estrellas,
 media: 3 estrellas, baja: menor o igual a 2 estrellas). 
 La calificación de un juego se calcula como el promedio entre todas las calificaciones.
Crear un menú que le permita al usuario buscar juegos en steam. 
*/
namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            steam steam =new steam();
            List<Juego> prueba=new List<Juego>();
            Console.WriteLine("¿Quiere buscar por genero o por calificacion?");
            string texto =Console.ReadLine();
            if (texto == "calificacion")
            {
                Console.WriteLine("¿alta, media o baja?");
                texto=Console.ReadLine();
                prueba=steam.buscarPorCalificacion(texto);
                foreach (var item in prueba)
                {
                    Console.WriteLine(item.Titulo);
                    
                }
            }
            else
            {
                Console.WriteLine("Ingrese el genero");
                texto=Console.ReadLine();
                prueba=steam.buscarPorGenero(texto);
                foreach (var item in prueba)
                {
                    Console.WriteLine(item.Titulo);
                }
            }


        }
    }
}
