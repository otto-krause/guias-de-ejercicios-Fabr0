/*
En una red social, las personas pueden tener amigos, fotos y publicaciones. Se pide:
Ver las fotos del último año de una persona (las fotos tienen un directorio de almacenamiento, fecha de creación y personas etiquetadas).
Dadas dos personas, ver las fotos en las que ambas están etiquetadas.
Ver todas las publicaciones que contengan más de 300 caracteres.
*/
using System.Collections.Generic;
using System;
namespace E7
{
    public class Fotos
    {
        string directorio;
        int fecha;
        List<Persona> etiquetados= new List<Persona>{};

        public int Fecha { get => fecha; set => fecha = value; }
    }
}