using System;
using System.Collections.Generic;
/*
Se pide:
Instanciar al menos 3 alfajores diferentes.
Crear los métodos para cada evento que cambia los precios.
Decir el estado de la inflación, siendo que se suman los precios de todos los alfajores existentes y:
Es normal, si el precio es menor a 500.
Es super, si el precio es mayor a 500 y menor a 1000.
Es hyper, si es mayor a 1000 pesos.
Mostrar si la Argentina está en default, esto ocurre si hay hiperinflación y solo existe un productor de alfajores (el resto se fundió).
    Alfajor alf1 =new Alfajor("Triple de Dulce de leche",25.50,"Guaymallen");
            Alfajor alf2 =new Alfajor("Clasico",35,"Terrabusi");
            Alfajor alf3 =new Alfajor("Chocolate",40,"Jorgito");
*/
namespace E7
{
    class Program
    {    
        static void Main(string[] args)
        {
            Argentina argentina=new Argentina();
            argentina.Mostrar();
            argentina.BajarElPrecioDelPetroleo();
            Console.WriteLine("El nivel de inflacion es "+argentina.Inflación());
            argentina.Mostrar();
            string texto= argentina.Defoult() ? "Argentina esta en defoult" : "Argentina esta bien";
            Console.WriteLine(texto);
            argentina.MilllaiHablaPorTV();
            argentina.Mostrar();
            argentina.CoronaVairas();
            argentina.Mostrar();
            Console.WriteLine("El nivel de inflacion es "+argentina.Inflación());
            argentina.Mostrar();

        }
     
    }
}