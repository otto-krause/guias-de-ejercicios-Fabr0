namespace Ejercicio
{
    public abstract class Spiderman
    {
        private int fuerza;
        protected Traje traje;

        public int Fuerza { get => fuerza; set => fuerza = value; }

        protected Spiderman(int fuerza, Traje traje)
        {
            this.Fuerza = fuerza;
            this.traje = traje;
        }

        public abstract int poder();
        public void atacar(Kingpin kingping){
            kingping.Vida -= this.poder();
        }
    }
}