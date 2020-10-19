namespace Ejercicio
{
    public class Terence : Pajaros
    {
        int vecesQueSeEnojo;

        int multiplicador;

        public Terence(int ira, int multiplicador) : base(ira)
        {

            vecesQueSeEnojo = 1;
            this.multiplicador = multiplicador;
        }

        public override void enojarse()
        {
            Ira = 2 * Ira;
        }

        public override int fuerza()
        {
            return Ira*vecesQueSeEnojo*multiplicador;
        }
    }
}