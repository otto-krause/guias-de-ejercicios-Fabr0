using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class IslaPajaros
    {
        List<Pajaros> pajaros;

        public IslaPajaros(List<Pajaros> pajaros)
        {
            this.pajaros = pajaros;
        }
        public List<Pajaros> Pajaros()
        {
            return pajaros;
        }
        public int DevolverFuerza(int num)
        {
            return pajaros[num].fuerza();
        }
        public List<Pajaros> fuertes()
        {
            return pajaros.Where(x => x.fuerza() > 50).ToList();
        }
        public int fuerzaIsla()
        {
            return this.fuertes().Sum(x=> x.fuerza());
        }
        public void sesionManejoIra(List<Pajaros> pajaros)
        {
            pajaros.ForEach(x=> x.Ira-=5);
            
        }
        public void invacionCerditos(int cerditos) //solucionar mambo
        {
            int cant= cerditos/100; 
            pajaros.ForEach(x=> x.enojarse());
        }
        public void fiestaSorpresa(List<Pajaros> homenajeados)
        {
            homenajeados.ForEach(x=> x.enojarse());
        }
        public void serieDeEventosDesafortunados(List<Pajaros> homenajeados,int cerditos)
        {
            sesionManejoIra(pajaros);
            invacionCerditos(cerditos);
            fiestaSorpresa(homenajeados);
        }
        public void QuitarPajaro(Pajaros paj)
        {
            pajaros.Remove(paj);
        }
        //metodo que hace eventos secuencialmente
    }
}