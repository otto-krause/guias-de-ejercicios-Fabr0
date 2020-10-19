using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Matilda : Pajaros
    {
        private List<int> huevos;

        public Matilda(int ira,List<int> huevos) : base(ira)
        {
            this.huevos=huevos;
        }

        public override void enojarse()
        {
            huevos.Add(2);
        }

        public override int fuerza()
        {
            return Ira+ huevos.Sum();
        }
    }
}