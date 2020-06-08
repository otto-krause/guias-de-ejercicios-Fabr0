/*Sabemos que todos los animales tienen energía, cada vez que comen recuperan energía y cada vez que juegan pierden energía. 
Crear las clases Perro y Pajaro, que son animales y siguen las siguientes reglas:
Cuando un Perro come, recupera 15 de energía, mientras que cuando juega, pierde 20 de energía. 
Cuando un Pájaro come, recupera 10 de energía, mientras que cuando juega, pierde 5 de energía. 
Todos los animales recuperan energía cuando duermen.
Instanciar a un Perro y un Pájaro y permitir mediante consola, utilizar las acciones nombradas previamente.
*/
namespace E1
{
    public class Perro : Animal
    {
        public Perro(int energia):base(energia)
        {
            this.energia=energia;
        }
        public override void comer()
        {
            energia+=15;
        }

        public override void jugar()
        {
            energia-=20;
        }
    }
}