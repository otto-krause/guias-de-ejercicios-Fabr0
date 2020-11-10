using System.Collections.Generic;
using System.Linq;
namespace ejercicio
{
    public class OneForAll : Quirk
    {
        Heroe portador;

        public OneForAll(string nombre, float tiempoMin, string consecuencias,Heroe portador) : base(nombre, tiempoMin, consecuencias)
        {
            this.portador= portador;
           
        }

        public override bool esPeligroso()
        {
            return true;
        }

        public override float poder()
        {
            return base.poder()+ base.poder()*15/100;
        }

        public void traspasar(Heroe portadorNuevo)
        {
            //portador.quirk.Remove(quirk.Last());
            portador=portadorNuevo;
        }
    }
}