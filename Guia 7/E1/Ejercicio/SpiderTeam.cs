using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class SpiderTeam
    {
        
        List<Spiderman> equipo = new List<Spiderman>{};

        public SpiderTeam(List<Spiderman> equipo)
        {
            this.equipo = equipo;
        }

        public int fuerzaSpiderEquipo(){
            return equipo.Sum(x=> x.Fuerza);
        }
        public void volverCasa(Kingpin kingpin){
            equipo.OrderBy(x => x.poder());
            if(kingpin.fueVencido())
            equipo.RemoveAt(0);
            else
            Console.WriteLine("Error");
        }
        public void pelearConKingpin(Kingpin kingpin){
            equipo.ForEach(x=> x.atacar(kingpin));
        }
        public int poderSpiderEquipo()
        {
            return equipo.Sum(x=> x.poder());
        }

    }
}