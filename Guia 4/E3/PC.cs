/*PC: Cada vez que se agrega un juego a su lista de juegos, nose se suman puntos, porque pueden ser juegos piratas. 
Cada vez que juega un juego gana 10 puntos por la cantidad de horas de juego.
*/
namespace E3
{
    public class PC : Consola
    {
        public PC()
        {
        }

        public override void Agregar(Juego juego)
        {
            base.Agregar(juego);
        }

        public override void Jugar(int horas)
        {
            puntos+=10*horas;
        }


    }
}