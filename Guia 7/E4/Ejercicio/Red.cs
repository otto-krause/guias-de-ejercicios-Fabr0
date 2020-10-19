namespace Ejercicio
{
    public class Red : Pajaros
    {
        int vecesQueSeEnojo;

        public Red(int ira) : base(ira)
        {
            vecesQueSeEnojo=1;
        }

        public override void enojarse()
        {
            vecesQueSeEnojo++;
            Ira=2*Ira;
        }

        public override int fuerza()
        {
            return Ira*10*vecesQueSeEnojo;
        }

    }
}