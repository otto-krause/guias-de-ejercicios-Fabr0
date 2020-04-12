using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l1=0;
            int l2=0;
            int l3=0;
            Console.WriteLine("Ingrese los lados del triangulo");
            l1=Int32.Parse(Console.ReadLine());
            l2=Int32.Parse(Console.ReadLine());
            l3=Int32.Parse(Console.ReadLine());
            triangulo hierro = new triangulo(l1,l2,l3);
            if(hierro.EsEquilatero(l1,l2,l3))
            {
             Console.WriteLine("Es equilatero");
            }
            else
            {
                if (hierro.EsIsoseles(l1,l2,l3))
                {
                    Console.WriteLine("Es isoseles");
                }
                else
                {
                    Console.WriteLine("Es escaleno");
                }
            }
             if(hierro.EsRectangulo(l1,l2,l3))
                Console.WriteLine("Y ademas es rectangulo");
             
        }
    }
}
