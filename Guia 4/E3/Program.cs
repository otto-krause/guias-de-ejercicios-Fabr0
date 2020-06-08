/*
Crear la clase Empleado, todos los empleados tienen una cajaBancaria, de la cuál pueden extraer o depositar.
Existen los siguientes tipos de empleados:
RRHH: cuando les depositan cobran 5000 de base más 5000 por persona referida.
Programador: cuando les depositan ganan 20000 de base más 10000 si es junior, 20000 si es semiSenior y 40000 si es senior.
Administrativo: siempre se les depositan 35000 pesos.

*/
using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;
            rrhh jose=new rrhh(3);
            Programador juan=new Programador("semiSenior");
            Administrativo jorge=new Administrativo();
            do
            {
                Console.WriteLine("Ingrese:\n"+
                "1- para que cobre Jose(rrhh)\n"+
                "2- para que cobre Juan(programador)\n"+
                "3- para que cobre Jorge(admin)\n"+
                "4- para salir\n");
                texto=Console.ReadLine();
                switch (texto)
                {
                    case "1":
                        Console.WriteLine(jose.Cobrar());
                        break;
                    case "2":
                        Console.WriteLine(juan.Cobrar());
                        break;
                    case "3":
                        Console.WriteLine(jorge.Cobrar());
                        break;
                    default:
                        break;
                }
            } while (texto!="4");
        }
    }
}
