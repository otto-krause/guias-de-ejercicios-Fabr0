using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Mago
    {
        Varita varita;
        List<Receta> recetas= new List<Receta>{};

        public Mago(Varita varita, List<Receta> recetas)
        {
            this.varita = varita;
            this.recetas = recetas;
        }

        public bool esUnLento(Receta receta){
            return varita.tiempoReceta(receta)>30;
        }
        public bool noSeCuida(){
            return recetas.Where(receta=> receta.esDeGordo()==true).ToList().Count> recetas.Count/2;
        }
    }
}