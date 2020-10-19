namespace Ejercicio
{
    public class PajarosComunes : Pajaros
    {
        public PajarosComunes(int ira): base(ira)
        {

        }

        public override void enojarse()
        {
            Ira=2*Ira;
        }


        public override int fuerza()
        {
            return Ira*2;
        }


    }
}