using System;
using System.Collections.Generic;
/*5) Crear la clase Carrito que contiene una lista de productos que se llevan los clientes de un supermercado.
 De cada Producto sabemos nombre y precio. 
 Crear la clase Supermercado que contiene una lista de carritos, y el método ganancias,
  que nos dice cuánto ganó el supermercado en ese día.

Nota: No ingresar valores, simplemente modelar el ejercicio.
*/
namespace E5
{
    public class Producto
    {
        string nombre;
        double precio=0;
        public Producto(string nombre,double precio)
        {
            this.nombre=nombre;
            this.precio=precio;
        }
        public double Plata()
        {
            return precio;
        }
    }
}