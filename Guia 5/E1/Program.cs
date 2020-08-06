/*De una lista de Personas (nombre, apellido, edad):
Mostrar todas las que sean mayores de edad.
Mostrar todas las que se llamen “Juan”.
Contar a todas las que se apellidan “Pérez”.
*/
using System;
using System.Collections.Generic;
using System.Linq;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int resp=0;
            List<Persona> personas= new List<Persona>();
            personas.Add(new Persona("Juan","Perez",32));
            personas.Add(new Persona("Fabrizio","Lombardo",17));
            personas.Add(new Persona("Juan","Aresta",25));


            Console.WriteLine("Ingrese:\n"
            +"1-Para ver a las personas mayores de edad\n"
            +"2-Para ver todas las personas que se llaman Juan\n"
            +"3-Para ver cuantos Perez hay\n");
            resp=Int32.Parse(Console.ReadLine());
            switch (resp)
            {
                case 1:
                    personas.Where(persona=> persona.Edad >17)
                    .ToList()
                    .ForEach(persona => Console.WriteLine(persona.Nombre));
                    break;
                case 2:
                 personas.Where(persona=> persona.Nombre =="Juan")
                    .ToList()
                    .ForEach(persona => Console.WriteLine(persona.Apellido));
                    break;
                case 3:
                    Console.WriteLine(personas.Count(persona=> persona.Apellido =="Perez"));
                    break;
                default:
                    break;
            }
        }
    }
}
