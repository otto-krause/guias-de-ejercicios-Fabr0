using System;
using System.Collections.Generic;   
/*1) Crear un programa que le permita al usuario ingresar tantos números como desee hasta que ingrese un 0,
 lo que se considerará como la finalización del ingreso. Estos números deben ser almacenados en una lista.

En base al programa anterior, realizar los siguientes ejercicios:

Mostrar por pantalla todos los números. -
Mostrar cuántos números fueron ingresados. -
Mostrar cúal fue el primer número. -
Mostrar cúal fue el último número. -
Mostrar cuántos números son mayores a 50.
*/
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1,cont=0;
            List<int>numeros = new List<int>();
            while (num!=0)
            {
                Console.WriteLine("Ingrese un numero");
                num=Int32.Parse(Console.ReadLine());
                numeros.Add(num);
            }
            foreach (int i in numeros)
            {
                Console.WriteLine("Valores de la lista:"+i);
                if (i>50)
                cont++;
            }
            Console.WriteLine("Fueron ingresados "+numeros.Count);
            Console.WriteLine("El primer numero ingresado fue "+numeros[0]);
            Console.WriteLine("El ultimo numero ingresado fue "+numeros[numeros.Count-2]);
            Console.WriteLine("Hay "+cont+" mayores que 50");

        }
    }
}
