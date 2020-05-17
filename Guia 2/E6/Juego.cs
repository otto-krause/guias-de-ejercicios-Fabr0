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
    public class Juego
    {
        string titulo;
        string genero;
        List<Calificacion> calificaciones;

        public Juego(string titulo, string genero, List<Calificacion> calificaciones)
        {
            this.Titulo = titulo;
            this.Genero = genero;
            this.Calificaciones = calificaciones;
        }

        public List<Calificacion> Calificaciones { get => calificaciones; set => calificaciones = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Genero { get => genero; set => genero = value; }

        public float Promedio()
        {
            float prom=0;
            foreach (var item in calificaciones)
            {
              prom+=item.Puntuacion;
            }
           return prom/Calificaciones.Count;
        }
        public string Calificar()
        {
            string texto;
            if (this.Promedio()>=4)
            {
                texto="alta";
            }
            else
            {
                if (this.Promedio()<=2)
                {
                    texto="baja";
                }
                else
                {
                    texto="media";
                }
            }
            return texto;
        }
    }
}