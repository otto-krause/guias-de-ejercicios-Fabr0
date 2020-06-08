/*
Monsters Inc es una empresa que se dedica al abastecimiento de energía mediante la interacción con niños, 
para ello cuentan con un personal que se dedica a interactuar con los niños. 
Los monstruos se manejan con un sistema de puntos de respeto. Existen 2 tipos de monstruos:

Peligrosos: Cada vez que asustan a un niño, generan 5 puntos de respeto. 
Si tienen que hacer reír a un niño pierden 2 puntos de respeto, porque no es su fuerte.

Amigables: Cada vez que un monstruo amigable hace reír a un niño, gana solo 1 punto de respeto. 
Cada vez que asusta a un niño gana 7 puntos de respeto.

Se pide:
Que la empresa pueda tener una NocheDeSustos o una NocheDeRisas, en la cual cada monstruo asustara o hará reír a un niño respectivamente.
Poder listar a los monstruos respetables, un monstruo es respetable cuando tiene más de 70 puntos de respeto.
Ver cuánta energía generó la empresa (sumatoria del respeto de todos los monstruos).
*/
namespace E2
{
    public abstract class Monstruo
    {
        protected int respeto;

        protected string nombre;

        public Monstruo(int respeto, string nombre)
        {
            this.respeto = respeto;
            this.nombre = nombre;
        }


        public abstract void Asustar();
        
        public abstract void Reir();

        public bool Respetable()
        {
            return respeto > 70;
        }
        public int Respeto()
        {
            return respeto;
        }
         public override string  ToString()=> this.nombre +" es respetable";
    }
}