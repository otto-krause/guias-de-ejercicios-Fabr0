namespace Ejercicio
{
    public class ParedesVidrio : Obstaculos
    {
        int ancho;

        public ParedesVidrio(int ancho)
        {
            this.ancho = ancho;
        }

        public int resistencia()
        {
            return 10*ancho;
        }
    }
}