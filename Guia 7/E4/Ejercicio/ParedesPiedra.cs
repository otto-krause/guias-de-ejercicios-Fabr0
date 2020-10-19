namespace Ejercicio
{
    public class ParedesPiedra : Obstaculos
    {
        int ancho;
        public ParedesPiedra(int ancho)
        {
            this.ancho = ancho;
        }

        public int resistencia()
        {
            return ancho * 50;
        }
    }
}