using System;
/*Sabemos que todos los animales tienen energía, cada vez que comen recuperan energía y cada vez que juegan pierden energía.
 Crear las clases Perro y Pajaro, que son animales y siguen las siguientes reglas:
Cuando un Perro come, recupera 15 de energía, mientras que cuando juega, pierde 20 de energía. 
Cuando un Pájaro come, recupera 10 de energía, mientras que cuando juega, pierde 5 de energía. 
Todos los animales recuperan energía cuando duermen.
Instanciar a un Perro y un Pájaro y permitir mediante consola, utilizar las acciones nombradas previamente.
*/
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro Lassie =new Perro(30);
            Pájaro Piolin=new Pájaro(10);
            string texto;
            int num=0;
            do
            {
                Console.WriteLine("Ingrese:\n"+
                "1- Para que Lassie juegue\n"+
                "2- Para que Lassie coma\n"+
                "3- Para que Lassie duerma\n"+
                "4- Para que Piolin juegue\n"+
                "5- Para que Piolin coma\n"+
                "6- Para que Piolin duerma\n"+
                "7- Para salir\n");
                texto=Console.ReadLine();
                switch (texto)
                {
                    case "1":
                        Lassie.jugar();
                        Console.WriteLine(Lassie.Mostrar());
                        break;
                    case "2":
                        Lassie.comer();
                        Console.WriteLine(Lassie.Mostrar());
                        break;
                    case "3":
                        Console.WriteLine("Ingrese las horas de sueño");
                        num=Int32.Parse(Console.ReadLine());
                        Lassie.dormir(num);
                        Console.WriteLine(Lassie.Mostrar());
                        break;
                    case "4":
                        Piolin.jugar();
                        Console.WriteLine(Piolin.Mostrar());
                        break;
                    case "5":
                        Piolin.comer();
                        Console.WriteLine(Piolin.Mostrar());
                        break;    
                    case "6":
                        Console.WriteLine("Ingrese las horas de sueño");
                        num=Int32.Parse(Console.ReadLine());
                        Piolin.dormir(num);
                        Console.WriteLine(Piolin.Mostrar());
                        break;
                    case "7":
                        break;
                }

            } while (texto!="7");
        }
    }
}
