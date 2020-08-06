/*
Crear un programa que le permita al usuario ingresar tantos números como desee hasta que ingrese un 0,
lo que se considerará como la finalización del ingreso. Estos números deben ser almacenados en una lista.

En base al programa anterior, realizar los siguientes ejercicios:

Mostrar por pantalla todos los números.
Mostrar cuántos números impares fueron ingresados.
Mostrar cúal fue el primer número par.
Mostrar los números que son mayores a 50.
Mostrar cuántos números son mayores a 50
*/
using System;
using System.Collections.Generic;
using System.Linq;
namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num=1;
            List<int> numeros=new List<int>{};
            while(num!=0)
            {
                num=Int32.Parse(Console.ReadLine());
                numeros.Add(num);
            }
            numeros.ForEach(x=> Console.WriteLine(x));
            Console.WriteLine("Cantidad numeros impares: "+numeros.Count(x=> x%2!=0));
            Console.WriteLine("Primer numero par: "+numeros.First(x=> x%2==0));
            numeros.Where(x=> x>50).ToList().ForEach(x=> Console.WriteLine(x));
            Console.WriteLine("Cantidad de numeros mayores a 50: "+numeros.Count(numeros=> numeros>50));
        }
    }
}
