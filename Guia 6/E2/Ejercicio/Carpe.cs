namespace Ejercicio
{
    public class Carpe : Varita
    {
        public Carpe(int potencia) : base(potencia)
        {
        }

        public override int tiempoReceta(Receta receta)
        {
            return receta.Pasos.Count/potencia;
        }

    }
}