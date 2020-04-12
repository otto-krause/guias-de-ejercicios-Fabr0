using System;
/*Crear la clase Matematica la cual contendrá los siguientes métodos estáticos:
Fibonacci: que recibe un parámetro entero.
Factorial: que recibe un parámetro entero.
Mayor: que recibe dos números y devuelve el mayor (utilizar ternario).
Menor: que recibe dos números y devuelve el menor (utilizar ternario).
Cubo: que recibe un parámetro y lo devuelve al cubo.
En la class Program crear un menú que le permita el usuario utilizar todas las	funcionalidades creadas.*/
namespace E6
{
    class Matematica
    {
        public void Fibonacci(int num1)
        {
            int aux=0;
            int a=0;
            int b=1;
            for (int i = 0; i < num1; i++)
            {
                aux=a;
                a=b;
                b=aux+a;
                Console.WriteLine(""+a);
            }
        }
        public int Factorial(int num1)
        {
            int f=1;
            for (int i = 1; i < num1 ; i++)
            {
                f=i*f;
            }
            return f;
        }
        public int Cubo(int num1)
        {
            return num1*num1*num1;
        }
        public int Mayor(int  num1,int num2)
        {
            if (num1>num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        public int Menor(int  num1,int num2)
        {
            if (num1<num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }
        static void Main(string[] args)
        {
            int menu=0;
            int num1=0;
            int num2=0;
            Matematica clase= new Matematica();
            while (menu != 6)
            {
                Console.WriteLine("Ingrese el numero para la operacion deseada:\n1-Fibonacci\n2-Factorial\n3-Mayor\n4-Menor\n5-Cubo\n6-Finalizar");
                menu = int.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad de numeros Fibonacci que quiere ver");
                        num1 = int.Parse(Console.ReadLine());
                        clase.Fibonacci(num1);
                        break;
                    case 2:
                        Console.WriteLine("El factorial de que numero quiere ver?");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine(clase.Factorial(num1));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese dos numeros para comparar");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        clase.Mayor(num1, num2);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese dos numeros para comparar");
                        num1 = int.Parse(Console.ReadLine());
                        num2 = int.Parse(Console.ReadLine());
                        clase.Menor(num1, num2);
                        break;
                    case 5:
                        Console.WriteLine("El cubo de que numero quiere saber?");
                        num1 = int.Parse(Console.ReadLine());
                        clase.Cubo(num1);
                        break;
                    case 6:
                        break;
                }
            }

        }
    }
}

