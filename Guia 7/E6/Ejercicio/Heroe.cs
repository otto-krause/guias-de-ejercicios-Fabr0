using System.Collections.Generic;
using System.Linq;
namespace ejercicio
{
    public class Heroe
    {
        int victorias;
        int derrotas;
        string licencia;
        List<Quirk> quirk;

        public List<Quirk> Quirk { get => quirk; set => quirk = value; }

        public Heroe(int victorias, int derrotas,List<Quirk> quirk)
        {
            this.victorias = victorias;
            this.derrotas = derrotas;
            this.quirk= quirk;
            this.licencia ="licencia para luchar contra el crimen";
        }

        public float poder()
        {
            return quirk.Sum(x=> x.poder());
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