using System;
using System.Collections.Generic;
/*X es un cazador de Mavericks, encargado de mantener la paz en la tierra. Este lleva consigo su X-Buster y una armadura.



Modelar a X, que inicialmente tiene como armadura a la Falcon Armor. 
Se desea conocer la fuerza de X: ésta es igual al daño que causa su X-Buster (el cual es 10 inicialmente)
sumado a la bonificación de daño de la armadura que lleva.
Se desea que X pueda entrenar un tiempo. Esto provoca que su X-Buster aumente 
el daño base en 2 puntos por cada minuto entrenado, y provoque los efectos correspondientes en la armadura. 

Modelar lo siguiente: A lo largo de sus batallas X cambia su armadura por una nueva, la Shadow Armor.
Esta sombría armadura tiene un nivel de desgaste. Cada vez que X entrena con ella este desgaste aumenta 
tantos puntos como el daño que causa el X-Buster, independientemente del tiempo entrenado. 
La bonificación de daño que proporciona esta armadura es 80 dividido el desgaste.
*/
namespace E5
{
    public class Xbuster
    {
        int daño;

        public Xbuster()
        {
            this.Daño = 10;
        }

        public int Daño { get => daño; set => daño = value; }

        public void entrenamiento(int minutos)
        {
            Daño+=minutos*2;
        }
    }
}