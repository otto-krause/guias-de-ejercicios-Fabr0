using System.Collections.Generic;
using System;
namespace E6
{
    public class Calificacion
    {
        string comentario;
        int puntuacion;

        public Calificacion(string comentario, int puntuacion)
        {
            this.comentario = comentario;
            this.Puntuacion = puntuacion;
        }

        public int Puntuacion { get => puntuacion; set => puntuacion = value; }
    }
}