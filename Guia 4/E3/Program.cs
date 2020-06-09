/*
Crear la clase Consola, con la cual se pueden agregar juegos (digitales) a la su lista de juegos, jugar y revisar puntaje.
Existen los siguientes tipos de consolas:

CajaX: Cada vez que se agrega un juego a su lista de juegos, se suman 25 puntos. 
Cada vez que juega un juego gana 4 puntos por la cantidad de horas de juego.

PC: Cada vez que se agrega un juego a su lista de juegos, nose se suman puntos, porque pueden ser juegos piratas. 
Cada vez que juega un juego gana 10 puntos por la cantidad de horas de juego.

Ponystation4: Cada vez que se agrega un juego a su lista de juegos, se suman 29 puntos. 
Cada vez que juega un juego gana 3 puntos por la cantidad de horas de juego.

Ponystation4 pro SaladaEdition: Tiene los mismos comportamientos que su predecesora, 
pero cada vez que agrega un nuevo juego, pierde uno anterior, 
porque tiene poca memoria y cada vez que se revisa su puntaje devuelve la mitad, porque está rota.

Se pide:
Crear la clase Juego, que tiene un nombre, año de lanzamiento y el nombre de la consola en la que puede jugarse.
Hacer que las consolas entiendan los métodos elMasNuevo y elMasViejo, que devuelven el juego más nuevo y más viejo que contienen.
Crear la clase Jugador, que tiene un nombre y una lista de consolas.
Crear en Jugador el método adquirirJuego, que recibe un juego y lo guarda en su respectiva consola.
Crear en Jugador el método laMasUsada, que devuelve cuál fue la consola con la que obtuvo mayor puntaje.
*/
using System;
using System.Collections.Generic;
namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<Consola> consolasF=new List<Consola>{new CajaX(),new PC(),new Ponystation4(),new Ponystation4Salada()};
            Jugador Fabri=new Jugador("Fabri",consolasF);
            string texto;
            do
            {
                Console.WriteLine("Ingrese:\n"+
                "1- Para ver el juego mas nuevo de una consola\n"+
                "2- Para ver el juego mas viejo de una consola\n"+
                "3- Para guardar un juego en su consola\n"+
                "4- Para ver la consola mas usada\n"+
                "5- Para jugar\n"+
                "salir para finalizar\n");
                texto=Console.ReadLine();
                switch (texto)
                {
                    case "1":
                        Console.WriteLine("Ingrese de que consola");
                        texto=Console.ReadLine();
                        foreach (var item in consolasF)
                        {
                            if(texto==item.ToString())
                            item.elMasNuevo();
                        }
                        break;
                    case "2":
                        Console.WriteLine("Ingrese de que consola");
                        texto=Console.ReadLine();
                        foreach (var item in consolasF)
                        {
                            if(texto==item.ToString())
                            item.elMasViejo();
                        }
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el juego a guardar (nombre,año,consola)");
                        Juego jueguito=new Juego(Console.ReadLine(),Int32.Parse(Console.ReadLine()),Console.ReadLine());
                        foreach (var item in consolasF)
                        {
                            if(jueguito.Consola==item.ToString())
                            Fabri.adquirirJuego(jueguito);
                        }
                        break;
                    case "4":
                        Console.WriteLine(Fabri.laMasUsada());
                        break;
                    case "5":
                        Console.WriteLine("En que consola va a jugar ?");
                        texto=Console.ReadLine();
                        foreach (var item in consolasF)
                        {
                            if(texto==item.ToString())
                            {
                            Console.WriteLine("Cuantas horas?");
                            int num=int.Parse(Console.ReadLine());
                            item.Jugar(num);
                            }
                        }
                        break;
                    case "salir":
                        break;
                    default:
                        break;
                }
            } while (texto!="salir");
        }
    }
}
