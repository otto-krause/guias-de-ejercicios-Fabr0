/*
Tenemos una lista de Caballeros del Zodiaco (nombre, dios al que apoya, y una armadura, signo del zodiaco). 
De cada armadura sabemos que tienen nombre, material (bronce, plata, oro). Requerimos lo siguiente:
Mostrar todas las armaduras de los caballeros que apoyen a Atena.
Mostrar los nombres de todos los dioses, sin repetidos.
Mostrar a todos los signos del zodiaco que empiecen con la letra C.

*/
using System;
using System.Collections.Generic;
using System.Linq;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<Caballero> caballeros= new List<Caballero>{};
            caballeros.Add(new Caballero("Shiryu","Atena",new Armadura("Dragon","Bronce")));
            caballeros.Add(new Caballero("Radamanthys","Hades",new Armadura("Wyvern","Oro")));
            caballeros.Add(new Caballero("Shura","Atena",new Armadura("Capricornio","Oro")));
            int menu;
            Console.WriteLine("Ingrese:\n"
            +"1 para ver tpdas las armaduras de los caballeros que apoyen a Atena\n"
            +"2 para ver los nombres de todos los dioses\n"
            +"3 para ver todos los signos que empiezen con c\n");
            menu=Int32.Parse(Console.ReadLine());
            switch (menu)
            {
                case 1:
                    caballeros.Where(caballero => caballero.Dios=="Atena")
                    .ToList()
                    .ForEach(caballero => Console.WriteLine(caballero.Armadura.Nombre));
                    break;
                case 2:
                  
                    caballeros.ForEach(caballero=> Console.WriteLine(caballero.Dios.Distinct().OrderBy(a=> a)));//no me tira bien el nombre
                    break;
                case 3:
                    caballeros.Where(caballero=> caballero.Armadura.Nombre.Substring(0,1)=="C")
                    .ToList()
                    .ForEach(caballero=> Console.WriteLine(caballero.Armadura.Nombre));
                    break;
                default:
                break;
            }
        }
    }
}
