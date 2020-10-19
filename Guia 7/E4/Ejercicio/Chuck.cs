namespace Ejercicio
{
    public class Chuck : Pajaros
    {
        int velocidadKmHs;
        public Chuck(int ira,int velocidadKmHs) : base(ira)
        {
            this.velocidadKmHs=velocidadKmHs;
        }

        public override void enojarse()
        {
            velocidadKmHs=2*velocidadKmHs;
        }

        public override int fuerza()
        {
            if(velocidadKmHs<80)
                return 150;
            return 150+5*(velocidadKmHs-80);
        }
    }
}