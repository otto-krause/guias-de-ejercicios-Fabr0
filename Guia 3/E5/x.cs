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
*/
namespace E5
{
    public class x
    {
        private Equipamiento armadura;
        private Xbuster xbuster =new Xbuster();

        public x()
        {
            this.armadura = new FalconArmor();

        }

        public float fuerza()
        {
            return armadura.bonificacionDaño() + xbuster.Daño;
        }
        public void entrenamiento(int minutos)
        {
            xbuster.entrenamiento(minutos);
            armadura.entrenamiento(minutos);
        }
        public void cambiarArmaduta(Equipamiento armaduraNueva)
        {
            armadura=armaduraNueva;
        }
        public int dañoXbuster()
        {
            return xbuster.Daño;
        }
    }
}