using System;
using System.Collections.Generic;
/*6) Steam es una plataforma para comprar juegos en línea, Valve no pidió ayuda para volver a recrear una de sus funcionalidades,
 usando el paradigma orientado a objetos. Según nos contaron, necesitan:
Crear la clase juego, que contiene el título del juego, su género y una lista de calificaciones.
Cada calificación está formada por un valor numérico (del 1 al 5) y un comentario, por ejemplo: 
	Estrellas: 2	Reseña: “Es malísimo, se tilda todo el tiempo”
	Estrellas: 5	Reseña: “Buenardo”
Crear la clase steam, que permite buscar los juegos por genero o por calificación (alta: mayor o igual a 4 estrellas,
 media: 3 estrellas, baja: menor o igual a 2 estrellas). 
 La calificación de un juego se calcula como el promedio entre todas las calificaciones.
Crear un menú que le permita al usuario buscar juegos en steam. 
*/
namespace E6
{
    public class steam
    {
        List<Juego> Epic=new List<Juego>();
        static List<Calificacion> CalificLoL= new List<Calificacion>{new Calificacion("Buenardo",5),new Calificacion("Muy toxica la gente",3)};
        static List<Calificacion> CalificGoW= new List<Calificacion>{new Calificacion("Es excelente",5),new Calificacion("Sarpado",5)};
        static List<Calificacion> CalificNMS = new List<Calificacion>{new Calificacion("Malisimo",1),new Calificacion("Se hicieron los poronga y es una cagada",1)};
          public steam()
        {
            Epic.Add(new Juego("Liga de Leyendas","Multiplayer Online Arena",CalificLoL));
            Epic.Add(new Juego("God of War","Tercera persona",CalificGoW));
            Epic.Add(new Juego("No Man's Sky","Mundo abierto",CalificNMS));
        }

        public List<Juego> buscarPorCalificacion(string texto)
        {
            List<Juego> busqueda= new List<Juego>();
            foreach (var juego in Epic)
            {
                if (juego.Calificar()==texto)
                {
                    busqueda.Add(juego);
                }
            }
            return busqueda;
        }
        public List<Juego> buscarPorGenero(string texto)
        {
            List<Juego> busqueda= new List<Juego>();
            foreach (var juego in Epic)
            {
                if (juego.Genero==texto)
                {
                    busqueda.Add(juego);
                }
            }
            return busqueda;
        }
    }
}