using System;
using System.Collections.Generic;
/*Crear la clase SerPensante, todos los seres pensantes tienen una lista de conocimientos y una lista de intereses
 (son listas de tipo string), además todos los seres pensantes pueden estudiar y pensar.

Robot: Cuando el robot piensa sobre un tema utiliza todos sus conocimientos
gana tantos puntos de inteligencia como conocimientos posea. 
Cuando el robot estudia, solo agrega el tema a su lista de conocimientos.

Humano: cuando un humano piensa sobre un tema, intenta utilizar sus últimos cinco conocimientos, 
si encuentra el tema, entonces gana 5 de inteligencia. Cuando el humano estudia, adquiere el conocimiento
 y si estaba en su lista de intereses, adquiere un punto de inteligencia.

Cyborg: estudia como humano y piensa como robot.
*/
namespace E5
{
    public class Humano :SerPensante
    {
        public Humano(List<string> intereces, List<string> conocimientos):base(intereces,conocimientos)
        {

        }
        public override void pensar(string tema)
        {
          
          foreach (var item in conocimientos)
          {
              if(item==tema)
              this.inteligencia+=5;
          }    
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