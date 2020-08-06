/*
Crear la clase Matematicas2, la cual recibe listas de números enteros y devuelve:
Primos: devuelve solo los números que son primos.
Pares: devuelve solo los números que son pares.
Aplanar: muestra la lista sin repetidos.
Suma: devuelve la sumatoria de todos los números.
SumaDePrimos: devuelve la sumatoria de todos los números que son primos.
Máximo: devuelve el número más grande.
Minimo: Devuelve el número más chico.
*/
using System;
using System.Collections.Generic;
using System.Linq;
namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista= new List<int>{1,2,3,4,5,6,7,8,9,21,32,4354,2};
            Matematicas numeros=new Matematicas(lista);
            Console.WriteLine("Ingrese:\n"+
            "1 para ver primos\n"+
            "2 para ver los pares\n"+
            "3 para ver la lista aplanada\n"
            +"4 para ver la suma de la lista\n"
            +"5 para ver el maximo\n"
            +"6 para ver el minimo\n");
            int resp=Int32.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    numeros.primo().ForEach(x=>Console.WriteLine(x) );
                    break;    
                case 2:
                    numeros.pares().ForEach(x=>Console.WriteLine(x) );
                    break;
                case 3:
                    numeros.aplanar().ForEach(x=>Console.WriteLine(x) );
                    break;
                case 4:
                    Console.WriteLine(numeros.suma());
                    break;
                case 5:
                    Console.WriteLine(numeros.maximo());
                    break;
                case 6:
                    Console.WriteLine(numeros.minimo());
                    break;
                default:
                break;
            }
        }
    }
}
