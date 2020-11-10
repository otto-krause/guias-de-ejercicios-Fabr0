
namespace ejercicio
{
    public abstract class Quirk
    {
        string nombre;

        float tiempoMin;
        string consecuencias;

        public Quirk(string nombre, float tiempoMin, string consecuencias)
        {
            this.tiempoMin=tiempoMin;
            this.nombre= nombre;
            this.consecuencias=consecuencias;
        }

        public virtual float poder()
        {
            return tiempoMin* nombre.Length;
        }
        public virtual bool esPeligroso()
        {
            return (poder()>1000 && tiempoMin> 60)|| consecuencias!= "";
        }

        
    }
}