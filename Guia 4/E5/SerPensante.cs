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
    public abstract class SerPensante
    {
        protected List<string> intereces=new List<string>();
        protected List<string> conocimientos=new List<string>();
        protected int inteligencia;

        public SerPensante(List<string> intereces, List<string> conocimientos)
        {
            this.intereces = intereces;
            this.conocimientos = conocimientos;
        }

        public abstract void pensar(string tema);
      
        public abstract void estudiar(string tema);
    }
}