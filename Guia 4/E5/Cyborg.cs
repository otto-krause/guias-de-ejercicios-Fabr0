using System;
using System.Collections.Generic;
/*Crear la clase SerPensante, todos los seres pensantes tienen una lista de conocimientos y una lista de intereses
 (son listas de tipo string), además todos los seres pensantes pueden estudiar y pensar.

Robot: Cuando el robot piensa sobre un tema utiliza todos sus conocimientos
gana tantos puntos de inteligencia como conocimientos posea. 
Cuando el robot estudia, solo agrega el tema a su lista de conocimientos.

Cyborg: cuando un Cyborg piensa sobre un tema, intenta utilizar sus últimos cinco conocimientos, 
si encuentra el tema, entonces gana 5 de inteligencia. Cuando el Cyborg estudia, adquiere el conocimiento
 y si estaba en su lista de intereses, adquiere un punto de inteligencia.

Cyborg: estudia como Cyborg y piensa como robot.
*/
namespace E5
{
    public class Cyborg :SerPensante
    {
        public Cyborg(List<string> intereces, List<string> conocimientos):base(intereces,conocimientos)
        {

        }
       public override void pensar(string tema)
        {
          this.inteligencia+= this.conocimientos.Count;      
        }
        public override void estudiar (string tema)
        {
            this.conocimientos.Add(tema);
            foreach (var item in intereces)
            {
                if(tema==item)
                inteligencia++;
            }
        }
    }
}