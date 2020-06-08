/*Sabemos que todos los animales tienen energía, cada vez que comen recuperan energía y cada vez que juegan pierden energía.
 Crear las clases Perro y Pajaro, que son animales y siguen las siguientes reglas:
Cuando un Perro come, recupera 15 de energía, mientras que cuando juega, pierde 20 de energía. 
Cuando un Pájaro come, recupera 10 de energía, mientras que cuando juega, pierde 5 de energía. 
Todos los animales recuperan energía cuando duermen.
Instanciar a un Perro y un Pájaro y permitir mediante consola, utilizar las acciones nombradas previamente.
*/
namespace E1
{
    public abstract class Animal
    {
        protected int energia;

        protected Animal(int energia)
        {
            this.energia = energia;
        }

        public abstract void comer();
        public abstract void jugar();
        public void dormir(int num){
            energia+=num;
        }
        public int Mostrar()
        {
            return energia;
        }
    }
}