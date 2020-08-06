/*Crear la clase Carrito que contiene una lista de productos que se llevan los clientes de un supermercado.
 De cada Producto sabemos nombre y precio. Crear la clase Supermercado que contiene una lista de carritos, 
 y el método ganancias, que nos dice cuánto ganó el supermercado en ese día.

Nota: No ingresar valores, simplemente modelar el ejercicio.

*/
using System;
namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Supermercado supermercado= new Supermercado{};

            Console.WriteLine("La ganancia total es de ",supermercado.Ganancias());
        }
    }
}
