using System;
namespace Ejercicio
{
    public abstract class Pajaros
    {
        int ira;

        public int Ira { get => ira; set => ira = value; }

        protected Pajaros(int ira)
        {
        }

        public abstract int fuerza();
        public abstract void enojarse();
    }
}