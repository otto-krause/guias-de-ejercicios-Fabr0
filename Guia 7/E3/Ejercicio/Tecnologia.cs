namespace Ejercicio
{
    public class Tecnologia
    {
        string nombre;
        int potencia;
        int usos;

        public Tecnologia(string nombre, int potencia, int usos)
        {
            this.Nombre = nombre;
            this.potencia = potencia;
            this.usos = usos;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public double poder(){
            return potencia/usos;
        }
    }
}