using System;
using System.Collections.Generic;
/*
Crear la clase PC, que tendrá un listado de diferente componente de computadora. Los componente entienden dos mensajes:
Precio: que nos dice cuanto sale el componente.
EsCompatible: que recibe como parámetro un mother, y nos dice si es compatible con el mismo.
Para saber si un componente es compatible, esto dependerá a veces del zócalo del mother y otras veces de la frecuencia
 o conectores que maneje.
Crear los siguientes componente: MemoriaRam, DiscoSSD, DiscoHDD, PlacaDeVideo, LectoraDeCD.
Cargar por consola al menos un componente de cada tipo en la PC; Esta última deberá responder a los siguientes mensajes: 
PrecioTotal: que mostrara cuanto cuesta la PC con todos sus componente.
SePuedeArmar: que nos dirá si es posible armar la computadora (todos sus componente son compatibles con el mother).
*/
namespace E3
{
    public class PC
    {
      List<Componente> Componente = new List<Componente>();
    
        Mother MotherASUS = new Mother("DDR4","Si","Si");

        public float PrecioTotal()
        {
            float precioTotal = 0;

            foreach(var i in Componente)
            {
                precioTotal += i.Precio();
            }

            return precioTotal;
        }
        
        public bool SePuedeArmar()
        {
            foreach (var i in Componente)
            {
                return (!i.EsCompatible(MotherASUS));     
            }
            return true;
        }

        public void IngresarComponentes()
        {
            string texto;

            int precioAux;
            
            Console.WriteLine("Ingrese el tipo de su MemoriaRam(DDR3, DDR4)\nY tambien su precio");
           texto = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            
            MemoriaRAM memoriaRam = new MemoriaRAM(texto,precioAux);



            Console.WriteLine("Su SSD es por Sata? (Si,No)\nY tambien su precio");
            texto = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            Componente.Add(new DiscoSSD(precioAux,texto));



            Console.WriteLine("Su HHD es por Sata? (Si,No)\nY tambien su precio");
            texto = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            Componente.Add(new DiscoHHD(precioAux,texto));



            Console.WriteLine("Su Placa de video es por PCIE? (Si,No)\nY tambien su precio");
            texto = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            Componente.Add(new PlacaVideo(precioAux,texto));



            Console.WriteLine("Su Lectora de CD es por Sata? (Si,No)\nY tambien su precio");
            texto = Console.ReadLine();
            precioAux = Int32.Parse(Console.ReadLine());
            Componente.Add(new LectorCD(precioAux,texto)); 
        }
    }
}