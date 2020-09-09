namespace Ejercicio
{
    public class MilesMorales : Spiderman
    {
        int habilidadCantar;

        public MilesMorales(int habilidadCantar, int fuerza, Traje traje) : base(fuerza, traje)
        {
            this.habilidadCantar = habilidadCantar;
        }
        
        public override int poder()
        {
            return Fuerza+ habilidadCantar;
        }

    }
}