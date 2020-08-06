/*
Tenemos una lista de Caballeros del Zodiaco (nombre, dios al que apoya, y una armadura, signo del zodiaco). 
De cada armadura sabemos que tienen nombre, material (bronce, plata, oro). Requerimos lo siguiente:
Mostrar todas las armaduras de los caballeros que apoyen a Atena.
Mostrar los nombres de todos los dioses, sin repetidos.
Mostrar a todos los signos del zodiaco que empiecen con la letra C.

*/
using System;
namespace E3
{
    public class Armadura
    {
        string nombre;
        string material;

        public Armadura(string nombre, string material)
        {
            this.nombre = nombre;
            this.material = material;
        }

        public string Nombre { get => nombre; set => nombre = value; }
    }
}