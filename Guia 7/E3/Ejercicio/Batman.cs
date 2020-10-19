using System;
using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Batman
    {
        List<Tecnologia> batiriñonera =new List<Tecnologia>{};
        int vida;
        int estres;

        public int Vida { get => vida; set => vida = value; }

        public Batman(List<Tecnologia> batiriñonera)
        {
            this.batiriñonera = batiriñonera;
            this.vida = 800;
            this.estres = 8;
        }
        public bool estaEstresado()
        {
            return estres>15;
        }
        public double fuerza(){
            return vida+ batiriñonera.Sum(x=> x.poder());
        }
        public void combatirCrimen(List<Villano> villanos){
            estres+=villanos.Count;
            if(!fuerzaBatmanMayor(villanos))
                vida-=200;

        }
        private bool fuerzaBatmanMayor(List<Villano> villanos){
            return fuerza() > villanos.Sum(x=> x.fuerza());

        }

        public void llorarPorSusPadres(Tecnologia herramienta)
        {
            estres-=10;
            batiriñonera.Remove(herramienta);
        }
        public void batiTwist()
        {
            vida+=100;
        }
        public bool estaDeModa()
        {
            return batiriñonera.All(h=> h.Nombre.StartsWith("bati"));
        }
    }

}