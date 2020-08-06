/*
En una red social, las personas pueden tener amigos, fotos y publicaciones. Se pide:
Ver las fotos del último año de una persona (las fotos tienen un directorio de almacenamiento, fecha de creación y personas etiquetadas).
Dadas dos personas, ver las fotos en las que ambas están etiquetadas.
Ver todas las publicaciones que contengan más de 300 caracteres.
*/
using System.Collections.Generic;
using System;
using System.Linq;
namespace E7
{
    public class Persona
    {
        string usuario;
        List<Fotos> fotos= new List<Fotos>{};
        List<Publicacion> publicaciones= new List<Publicacion>{};

        public Persona(string usuario)
        {
            this.usuario = usuario;
        }

        public List<Fotos> ultimasFotos(){
            return fotos.Where(fotos=> fotos.Fecha == 2020).ToList();
        }
    }
}