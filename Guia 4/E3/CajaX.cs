/*CajaX: Cada vez que se agrega un juego a su lista de juegos, se suman 25 puntos. 
Cada vez que juega un juego gana 4 puntos por la cantidad de horas de juego.*/
namespace E3
{
    public class CajaX : Consola
    {
        public CajaX()
        {
        }

        public override void Agregar(Juego juego)
        {
            base.Agregar(juego);
            puntos+=25;
        }

       

        public override void Jugar(int horas)
        {
            puntos+=4*horas;
        }


    
    }
}