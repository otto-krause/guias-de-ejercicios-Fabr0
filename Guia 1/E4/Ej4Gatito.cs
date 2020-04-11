namespace Visual
{
    public class Gatito
    {
        string nombre;

        bool vacunas;

        int energia;

        public Gatito(string nombre,bool vacunas,int energia)
        {
            this.nombre = nombre;
            this.vacunas = vacunas;
            this.energia = energia;
        }
        public string Nombre()
        {
        return this.nombre;
        }
        public bool EstaVacunado()
        {
            return this.vacunas;
        }
        public bool EstaSaludable()
        {
            return vacunas && energia >30;
        }

        public void Jugar(int min)
        {
            energia-= 2*min;
        }
        public void Comer()
        {
            energia+=50;
        }
  
    }
}
