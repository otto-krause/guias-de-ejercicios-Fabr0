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
    public class Supermercado
    {
        List<Carrito> carritos=new List<Carrito>();
        public Supermercado()
        {
            
        }
    
    public double Ganancias()
    {
        double suma=0;
        foreach (var item in carritos)
        {
            suma+=item.Plata1();
        }
        return suma;
    }
    }
   
}