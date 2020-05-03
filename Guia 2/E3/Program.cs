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
    class Program
    {
        static void Main(string[] args)
        {
            Album album =new Album();
            Console.WriteLine("Ingrese la figurita");
            string var1 =Console.ReadLine();
            string var2 =Console.ReadLine();
            string var3= Console.ReadLine();
            int var4 =Int32.Parse(Console.ReadLine());
            album.Corroborar(var1,var2,var3,var4);    
            album.Contar();
            album.EstaCompleto();
        }
    }
}
