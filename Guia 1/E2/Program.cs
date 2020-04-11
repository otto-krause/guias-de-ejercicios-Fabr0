using System;

namespace Visual
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1=0;
           int num2=0;
           int pro=0;
           int cos=0;
           int k=0;
           Console.WriteLine("Ingrese dos numeros");
           k=num1 = Int32.Parse(Console.ReadLine());
           num2 = Int32.Parse(Console.ReadLine());
           for (int i=1; i <=num2 ; i++)
           {
               pro+=num1;
               if (k>=num2)
               {
                   k-=num2;
                   cos +=1;
                   
               }
           }
           Console.WriteLine("El producto de los numeros es :"+pro);
           Console.WriteLine("El cociente entre los numeros es "+cos+" y tiene resto "+k);
        }
    }
}

