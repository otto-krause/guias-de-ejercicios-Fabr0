using System;
using System.Collections.Generic;
/*X es un cazador de Mavericks, encargado de mantener la paz en la tierra. Este lleva consigo su X-Buster y una armadura.

Modelar la armadura Falcon Armor, que tiene inicialmente una potencia de 25 y una resistencia de 10. 
Se desea conocer la bonificación de daño que otorga esta armadura, que se calcula como el promedio entre la potencia y la resistencia.
Se desea poder realizar un entrenamiento ciertos minutos con la Falcon Armor,
lo que provoca que su resistencia disminuya un punto por minuto
y su potencia aumente en 10 (independientemente de la cantidad de minutos entrenados).
La resistencia nunca puede ser negativa.

Modelar a X, que inicialmente tiene como armadura a la Falcon Armor. 
Se desea conocer la fuerza de X: ésta es igual al daño que causa su X-Buster (el cual es 10 inicialmente)
sumado a la bonificación de daño de la armadura que lleva.
Se desea que X pueda entrenar un tiempo. Esto provoca que su X-Buster aumente 
el daño base en 2 puntos por cada minuto entrenado, y provoque los efectos correspondientes en la armadura. 
Modelar lo siguiente: A lo largo de sus batallas X cambia su armadura por una nueva, la Shadow Armor.
Esta sombría armadura tiene un nivel de desgaste. Cada vez que X entrena con ella este desgaste aumenta 
tantos puntos como el daño que causa el X-Buster, independientemente del tiempo entrenado. 
La bonificación de daño que proporciona esta armadura es 80 dividido el desgaste.

1)Entrenamiento,fuerza,cambiar armadura
*/
namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            x X=new x();
            string texto = "";
            do
            {
                Console.WriteLine("Ingrese:\n" +
                "1)Mostrar fuerza\n" +
                "2)Entrenarmiento\n" +
                "3)Cambiar armadura\n" +
                "4)Salir\n");
                texto = Console.ReadLine();
                switch (texto)
                {
                    case "1":
                        Console.WriteLine(X.fuerza());
                        break;
                    case "2":
                        Console.WriteLine("Ingrese la cantidad de minutos");
                        int num=Int32.Parse(Console.ReadLine());
                        X.entrenamiento(num);
                        break;
                    case "3":
                        Equipamiento nuevaArmadura=new ShadowArmor(X.dañoXbuster());
                        X.cambiarArmaduta(nuevaArmadura);
                        break;
                    case "4":
                        texto="salir";
                        break;
                }
            } while (texto != "salir");
        }
    }
}
