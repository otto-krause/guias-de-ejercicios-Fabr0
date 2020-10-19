namespace Ejercicio
{
    public class CerditoArmado: Obstaculos
    {
        int arma;

        public CerditoArmado(int arma)
        {
            this.arma = arma;
        }

        public int resistencia()
        {
            return 10*arma;
        }
    }
}