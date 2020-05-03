using System;
using System.Collections.Generic;
/*3) Hacer un programa en el que se represente un album de figuritas del mundial. 
En cada figurita aparece el nombre del jugador, su posición, país y el número de figurita.
 Crearemos también la clase Album que contiene una lista con las figuritas que ya se agregaron.
Se pide:
Agregar una figurita al álbum: para esto el usuario ingresará los datos de la figurita por pantalla, 
y el abum controlará que esa figurita no haya sido ingresada previamente.
Mostrar CuantosDelanteros hay. 
Mostrar CuantosMediocampistas hay.
Decirle al usuario si el album EstaCompleto, para ello sabemos que en el álbum hay 32 equipos con 11 jugadores cada uno.

Nota: Pensar para los puntos B y C una forma de no repetir código.

*/
namespace E3
{
    public class Figurita
    {
        string nombre;
        string pos;
        string pais;
        int num;

        public Figurita(string nombre,string pos,string pais, int num)
        {
            this.nombre=nombre;
            this.pos=pos;
            this.pais=pais;
            this.num=num;
        }
        public int Numero()
        {
            return this.num;
        }
        public string Rol()
        {
            return this.pos;
        }
    }
}