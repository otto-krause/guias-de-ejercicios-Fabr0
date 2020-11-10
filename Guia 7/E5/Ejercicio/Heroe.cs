namespace Ejercicio
{
    public class Heroe
    {
        int victorias;
        int derrotas;
        string licencia;
        Quirk quirk;
        public Heroe(int victorias, int derrotas,Quirk quirk)
        {
            this.victorias = victorias;
            this.derrotas = derrotas;
            this.quirk= quirk;
            this.licencia ="licencia para luchar contra el crimen";
        }

        public float poder()
        {
            return quirk.poder();
        }
        public void pelear(Villano villano)
        {
            if(villano.poder()>this.poder())
            derrotas++;
            else
            victorias ++;
        }
        

    }
}