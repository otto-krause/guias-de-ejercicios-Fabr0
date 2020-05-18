using System;
using System.Collections.Generic;
/*
Crear la clase PC, que tendrá un listado de diferente componentes de computadora. Los componentes entienden dos mensajes:
Precio: que nos dice cuanto sale el componente.
EsCompatible: que recibe como parámetro un motherboard, y nos dice si es compatible con el mismo.
Para saber si un componente es compatible, esto dependerá a veces del zócalo del mother y otras veces de la frecuencia
 o conectores que maneje.
Crear los siguientes componentes: MemoriaRam, DiscoSSD, DiscoHDD, PlacaDeVideo, LectoraDeCD.
Cargar por consola al menos un componente de cada tipo en la PC; Esta última deberá responder a los siguientes mensajes: 
PrecioTotal: que mostrara cuanto cuesta la PC con todos sus componentes.
SePuedeArmar: que nos dirá si es posible armar la computadora (todos sus componentes son compatibles con el mother).
*/


namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            PC notebook = new PC();

            notebook.IngresarComponentes();

            Console.WriteLine("El precio total es " + notebook.PrecioTotal());

            if (notebook.SePuedeArmar())
                Console.WriteLine("Se puede armar");
            else
                Console.WriteLine("No se puede armar");
        }
    }
}
