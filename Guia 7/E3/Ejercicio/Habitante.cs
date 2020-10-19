namespace Ejercicio
{
    public class Habitante
    {
        double dinero;

        public double Dinero { get => dinero; set => dinero = value; }

        public Habitante(double dinero)
        {
            this.dinero = dinero;
        }
        public bool esClaseAlta()
        {
            return dinero>5000000;
        }
        public bool esClaseMedia()
        {
            return dinero<5000000 && dinero >1000000;
        }
        public bool esClaseBaja()
        {
            return dinero<1000000;
        }
        public void Asaltado()
        {
            dinero=0;
        }
        public double Robado()
        {
            return dinero;
        }
        public void Adquirido(double num)
        {
            dinero+=num;
        }
    }
}