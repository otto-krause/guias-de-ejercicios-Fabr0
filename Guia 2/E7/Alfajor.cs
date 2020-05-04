
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

Nosotros sabemos que los alfajores tienen un nombre, un precio, el nombre de la empresa que lo fabrica.
 Por ejemplo, están los alfajores que se llaman “Triple fruta” que salen 100 pesos y su empresa es “Waymayen”.

*/
namespace E7
{
    public class Alfajor
    {
        string nombre;
       public double precio;
        public string empresa;

    public Alfajor(string nombre, double precio, string empresa)
    {
        this.nombre=nombre;
        this.precio=precio;
        this.empresa=empresa;
    }
    }
}








