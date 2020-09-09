using System;
using System.Collections.Generic;
namespace Ejercicio
{
    public class SpiderGwen : Spiderman
    {
        int glamour;

        public SpiderGwen(int glamour,int fuerza, Traje traje) : base(fuerza, traje)
        {
            if(glamour < 1 || glamour > 10){
                throw new Exception("El glamour ingresado esta fuera de rango");
            }
            
        }

        public override int poder()
        {
            return Fuerza +glamour;
        }
    }
}