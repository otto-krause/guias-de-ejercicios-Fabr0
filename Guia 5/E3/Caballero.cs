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
    public class Caballero
    {
        string nombre;
       public  string dios;
        Armadura armadura;

        public Caballero(string nombre, string dios, Armadura armadura)
        {
            this.nombre = nombre;
            this.dios = dios;
            this.armadura = armadura;
        }

       
        public Armadura Armadura { get => armadura; set => armadura = value; }
        public string Dios { get => dios; set => dios = value; }
        public string devolverDios(){
            return dios;
        }
    }
}