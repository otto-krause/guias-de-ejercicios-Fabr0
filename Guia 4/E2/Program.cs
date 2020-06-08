/*
Monsters Inc es una empresa que se dedica al abastecimiento de energía mediante la interacción con niños, 
para ello cuentan con un personal que se dedica a interactuar con los niños. 
Los monstruos se manejan con un sistema de puntos de respeto. Existen 2 tipos de monstruos:

Peligrosos: Cada vez que asustan a un niño, generan 5 puntos de respeto. 
Si tienen que hacer reír a un niño pierden 2 puntos de respeto, porque no es su fuerte.

Amigables: Cada vez que un monstruo amigable hace reír a un niño, gana solo 1 punto de respeto. 
Cada vez que asusta a un niño gana 7 puntos de respeto.

Se pide:
Que la empresa pueda tener una NocheDeSustos o una NocheDeRisas, en la cual cada monstruo asustara o hará reír a un niño respectivamente.
Poder listar a los monstruos respetables, un monstruo es respetable cuando tiene más de 70 puntos de respeto.
Ver cuánta energía generó la empresa (sumatoria del respeto de todos los monstruos).
*/

using System;
using System.Collections.Generic;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            int RespetoEmpresa = 0;
            
            List<Monstruo> monstruos = new List<Monstruo>();

            monstruos.Add(new Peligroso(71,"Randal"));
            monstruos.Add(new Amigable(68,"Wasowsky"));
            monstruos.Add(new Amigable(68,"Sullyvan"));

            do
            {
                Console.WriteLine("Ingrese:\n"+
                "1- Para noche de susto\n"+
                "2- Para noche de risa\n"+
                "3- Para ver a los respetables\n"+
                "4- Para ver energia de la empresa\n"+
                "5- Para salir");
                texto =Console.ReadLine();

                switch(texto)
                {
                    case "1":
                        foreach (var i in monstruos)
                        {
                            i.Asustar();
                        }
                        break;
                    case "2":
                        foreach (var i in monstruos)
                        {
                            i.Reir();
                        }
                        break;
                    case "3":
                        foreach (var i in monstruos)
                        {
                            if(i.Respetable())
                            {
                                Console.WriteLine(i.ToString());
                            }
                        }
                        break;
                    case "4":
                        foreach (var i in monstruos)
                        {
                           RespetoEmpresa += i.Respeto(); 
                        }

                        Console.WriteLine("La energia de la empresa: " + RespetoEmpresa);
                        break;  
                   
                    default :
                        break; 
                }
            }while(texto != "5");
        }
    }
}