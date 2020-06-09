namespace E3
{
    /*Ponystation4 pro SaladaEdition: Tiene los mismos comportamientos que su predecesora, 
pero cada vez que agrega un nuevo juego, pierde uno anterior, 
porque tiene poca memoria y cada vez que se revisa su puntaje devuelve la mitad, porque está rota.
*/
    public class Ponystation4Salada : Ponystation4
    {
        public Ponystation4Salada()
        {
        }

        public override void Agregar(Juego juego)
        {
            juegos.Remove(juegos[0]);
            base.Agregar(juego);
        }

  

        public override float revisarPuntaje()
        {
            return base.revisarPuntaje()/2;
        }

    }
}