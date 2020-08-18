namespace Ejercicio
{
    public class Ingrediente
    {
         int calorias;
        string nombre;

        public Ingrediente(int calorias, string nombre)
        {
            this.calorias = calorias;
            this.nombre = nombre;
        }

        public int Calorias { get => calorias; set => calorias = value; }
    }
}