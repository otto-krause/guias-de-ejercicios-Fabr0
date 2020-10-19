namespace Ejercicio
{
    public class Bomb : Pajaros
    {
        int maximo;
        public Bomb(int ira) : base(ira)
        {
            maximo=9000;
        }

        public override void enojarse()
        {
            Ira=2*Ira;
        }

        public override int fuerza()
        {
            if(Ira*2<9000)
                return Ira*2;
            return Ira;
        }

      
    }
}