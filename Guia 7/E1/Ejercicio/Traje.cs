using System;
using System.Collections.Generic;
namespace Ejercicio
{
    public class Traje
    {
        int resistencia;
        List<Arma> armas =new List<Arma>{};

        public Traje(int resistencia, List<Arma> armas)
        {
            this.resistencia = resistencia;
            this.armas = armas;
        }

        public int Resistencia { get => resistencia; set => resistencia = value; }
        public List<Arma> Armas { get => armas; set => armas = value; }
    }
}