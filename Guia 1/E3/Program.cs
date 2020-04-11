using System;
//ver si el numero es par y si el numero es primo.
namespace Visual
{
    class Program
    {
        
        static void Main(string[] args)
        {
        
        int primo (int num1)
        {
            int cont=0;
            for (int i = 1; i <=num1; i++)
            {
                 if(num1%i==0)
                 {
                     cont++;
                 }
            }
            return cont;
    
        }
        int par (int num1)
        {
            if(num1%2==0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
           int num1=0;
    
           Console.WriteLine("Ingrese un numero");
           num1 = Int32.Parse(Console.ReadLine());
           if(primo(num1)==2)
           {
               Console.WriteLine("El numero es primo");
           }
           else
           {
               Console.WriteLine("El numero no es primo");
           }
           if(par(num1)==1)
           {
               Console.WriteLine("El numero es par");
           }
           else
           {
               Console.WriteLine("El numero es impar");
           }
  
        }
    }
}
