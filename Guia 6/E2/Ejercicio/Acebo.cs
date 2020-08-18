namespace Ejercicio
{
    public class Acebo : Varita
    {
        public Acebo(int potencia) : base(potencia)
        {
        }

        public override int tiempoReceta(Receta receta)
        {
            return potencia+ receta.Ingredientes.Count;
        }

    
    }
}