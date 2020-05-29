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
    class Program
    {
        static void Main(string[] args)
        {
            List<string> interecesHumano=new List<string>{"Astronomia","Videojuegos","Artes Marciales"};
            List<string> conocimientosHumano=new List<string>{"Biologia","MMA","Historia AC2"};
            List<string> interecesRobot=new List<string>();
            List<string> conocimientosRobot=new List<string>{"Matematica","Fisica","Programacion"};
           

            SerPensante Jorge=new Humano(interecesHumano,conocimientosHumano);
            SerPensante hijoDeElonMusk= new Cyborg(interecesHumano,conocimientosRobot);
            SerPensante R2D2=new Robot(interecesRobot,conocimientosRobot);
            
        }
    }
}
