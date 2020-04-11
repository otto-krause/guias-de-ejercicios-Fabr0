using System;

namespace Visual
{
    class Program
    {
        
        static void Main(string[] args)
        {
        int num=0;
        int min=0;
            Gatito garfield = new Gatito("Garfield",true,50);
            while (num !=6)
            {
                  Console.WriteLine("Escriba el numero para ejecutar el mensaje:\n1-Nombre\n2-EstaVacunado\n3-Jugar\n4-Comer\n5-EstaSaludable\n6-Finalizar");
            num=Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Console.WriteLine(garfield.Nombre());
                    break;
                case 2:
                    Console.WriteLine(garfield.EstaVacunado());
                    break;
                case 3:
                    Console.WriteLine("Ingrese los minutos que jugo");
                    min= Int32.Parse(Console.ReadLine());
                    garfield.Jugar(min);
                    break;
                case 4:
                    garfield.Comer();
                    break;
                case 5:
                    if(garfield.EstaSaludable())
                        Console.WriteLine("Si");
                    else
                        Console.WriteLine("No");
                    break;
          
                case 6:
                    break;
               

                    
            }
 
            }
         
        }
    }
}
