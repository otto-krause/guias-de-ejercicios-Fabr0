namespace Ejercicio
{
    public class PeterParker : Spiderman
    {
        public PeterParker(int fuerza, Traje traje) : base(fuerza, traje)
        {
        }

        public override int poder()
        {
            return Fuerza+ traje.Resistencia;
        }
    }
}