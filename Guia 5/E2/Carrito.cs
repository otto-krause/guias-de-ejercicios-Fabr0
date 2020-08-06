/*Crear la clase Carrito que contiene una lista de productos que se llevan los clientes de un supermercado.
 De cada Producto sabemos nombre y precio. Crear la clase Supermercado que contiene una lista de carritos, 
 y el método ganancias, que nos dice cuánto ganó el supermercado en ese día.

Nota: No ingresar valores, simplemente modelar el ejercicio.

*/
using System;
using System.Collections.Generic;
namespace E2
{
    public class Carrito
    {
        List<Producto> productos=new List<Producto>{};

        public Carrito(List<Producto> productos)
        {
            this.productos = productos;
        }
        public double TotalCarrito(){
            double suma=0;
            productos.ForEach(producto=> suma+= producto.Precio);
            return suma;
        }
    }
}