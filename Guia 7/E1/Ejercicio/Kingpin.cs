namespace Ejercicio
{
    public class Kingpin
    {
        int vida;

        public Kingpin()
        {
            this.vida = 800;
        }

        public int Vida { get => vida; set => vida = value; }

        public bool fueVencido(){
            return vida<0;
        }
    }
}