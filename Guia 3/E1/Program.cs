using System;
using System.Collections.Generic;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            SrBurns srBurns = new SrBurns();
            Homero homero = new Homero(2);
            Lenny lenny = new Lenny();
            Planta planta = new Planta(10000, homero, srBurns);
            PatoBalancin pato = new PatoBalancin();
            planta.cambiarEmpleado(lenny);
            string opcion = "";
            do
            {
                Console.WriteLine(
                    "1) Ver si la planta esta en peligro\n" +
                    "2)Homero come dona\n" +
                    "3)Homero compra donas\n" +
                    "4)Lenny toma cerveza\n" +
                    "5)Cambiar empleado por Homero\n" +
                    "6)Cambiar empleado por Lenny\n" +
                    "7)Cambiar empleado por PatoBalancin\n" +
                    "8)Despojar a Burns de sus riquezas\n" +
                    "9)Cargar uranio\n");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine(planta.estaEnPeligro());
                        break;
                    case "2":
                        homero.comer();
                        break;
                    case "3":
                        homero.comprar();
                        break;
                    case "4":
                        lenny.tomarCerveza();
                        break;
                    case "5":
                        planta.cambiarEmpleado(homero);
                        break;
                    case "6":
                        planta.cambiarEmpleado(lenny);
                        break;
                    case "7":
                        planta.cambiarEmpleado(pato);
                        break;
                    case "8":
                        srBurns.despojarRiquezas();
                        break;
                    case "9":
                        Console.WriteLine("Cantidad de uranio");
                        int num=Int32.Parse(Console.ReadLine());
                        planta.cargamentoUranio(num);
                        break;
                    default:
                        opcion = "salir";
                        break;
                }
            } while (opcion != "salir");
        }
    }
}
