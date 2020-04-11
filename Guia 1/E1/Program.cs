using System;

namespace Visual
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];
            int[] ordenado = new int[10];
            int suma=0;
            int aux=0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un numero");
                vector[i] = Int32.Parse(Console.ReadLine());
                suma+=vector[i];
            }       
            for (int i = 0; i <(10-1); i++)
            {
                for (int k = i+1; k < 10; k++)
                {
                    if (vector[i]<vector[k])
                    {
                        aux=vector[i];
                        vector[i]=vector[k];
                        vector[k]=aux;
                    }
                    
                }
            }   
             Console.WriteLine("La suma es: " + suma);
             Console.WriteLine("El promedio es: " + suma/10);
             Console.WriteLine("El menor elemento es: "+ vector[9]);
             for (int i = 0; i < 10; i++)
             {
                 Console.WriteLine(vector[i]);
             }
        }
    }
}
