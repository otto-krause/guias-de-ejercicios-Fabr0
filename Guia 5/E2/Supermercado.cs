/*Crear la clase Carrito que contiene una lista de productos que se llevan los clientes de un supermercado.
 De cada Producto sabemos nombre y precio. Crear la clase Supermercado que contiene una lista de carritos, 
 y el método ganancias, que nos dice cuánto ganó el supermercado en ese día.

Nota: No ingresar valores, simplemente modelar el ejercicio.

*/
using System;
using System.Collections.Generic;
namespace E2
{
    public class Supermercado
    {
        List<Carrito> carritos= new List<Carrito>{};

        public Supermercado()
        {
            List<Carrito> carrotes=carritos;
        }
        public double Ganancias(){
            double suma=0;
            carritos.ForEach(carritos=> suma+= carritos.TotalCarrito());
            return suma;
        }
    }
}