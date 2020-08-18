namespace teenTitans
{
    public class Arma
    {
        private int dureza;
        private int potencia;

        public Arma(int dureza, int potencia)
        {
            this.dureza = dureza;
            this.potencia = potencia;
        }

        public int fuerza(){
            return 0;
        }
        public int fibonacci(){
            int a = 0, b = 1, c = 0;
            for (int i = 0; i < dureza; i++)
            {
                a=b;
                b=c;
                c=a+b;
            }
            return dureza==0 ? 0 : dureza==1? 1:c;
        }
    }
}