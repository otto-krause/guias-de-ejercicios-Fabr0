/*De una lista de Personas (nombre, apellido, edad):
Mostrar todas las que sean mayores de edad.
Mostrar todas las que se llamen “Juan”.
Contar a todas las que se apellidan “Pérez”.
*/
using System;
using System.Linq;
using System.Collections.Generic;
namespace E1
{
    public class Persona
    {
        string nombre;
        string apellido;
        int edad;

        public Persona(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}