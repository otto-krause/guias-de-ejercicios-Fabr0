namespace Ejercicio
{
    public class ParedesMadera : Obstaculos
    {
        int ancho;

        public ParedesMadera(int ancho)
        {
            this.ancho = ancho;
        }

        public int resistencia()
        {
            return  ancho*25;
        }
    }
}