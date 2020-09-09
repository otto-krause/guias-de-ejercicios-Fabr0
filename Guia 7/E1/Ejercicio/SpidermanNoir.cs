using System;
using System.Collections.Generic;
namespace Ejercicio
{
    public class SpidermanNoir : Spiderman
    {
        public SpidermanNoir(int fuerza, Traje traje) : base(fuerza, traje)
        {
        }

        public override int poder()
        {
             return Fuerza+ traje.Resistencia + traje.Armas.Count;
        }
    }
}