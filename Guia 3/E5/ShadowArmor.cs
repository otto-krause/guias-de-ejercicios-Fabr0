using System;
using System.Collections.Generic;
/*
Modelar lo siguiente: A lo largo de sus batallas X cambia su armadura por una nueva, la Shadow Armor.
Esta sombría armadura tiene un nivel de desgaste. Cada vez que X entrena con ella este desgaste aumenta 
tantos puntos como el daño que causa el X-Buster, independientemente del tiempo entrenado. 
La bonificación de daño que proporciona esta armadura es 80 dividido el desgaste.
*/
namespace E5
{


    public class ShadowArmor :Equipamiento
    {
        int desgaste;
        int daño;
        public ShadowArmor(int daño)
        {
            this.desgaste = 1;
            this.daño=daño;
        }

        public void entrenamiento(int minutos)
        {
            desgaste+=daño;
        }
         public float bonificacionDaño()
        {
            return 80/desgaste;
        }
    }
}