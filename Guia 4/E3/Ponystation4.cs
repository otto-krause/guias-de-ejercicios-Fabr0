/*Ponystation4: Cada vez que se agrega un juego a su lista de juegos, se suman 29 puntos. 
Cada vez que juega un juego gana 3 puntos por la cantidad de horas de juego.
*/
namespace E3
{
    public class Ponystation4 : Consola
    {
        public Ponystation4()
        {
        }

        public override void Agregar(Juego juego)
        {
            base.Agregar(juego);
            puntos+=29;
        }


        public override void Jugar(int horas)
        {
            puntos+=3*horas;
        }

    }
}