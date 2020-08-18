using System.Collections.Generic;
using System;
using System.Linq;
namespace Ejercicio
{
    public class Receta
    {
        List<Ingrediente> ingredientes= new List<Ingrediente>();
        List<string> pasos= new List<string>{};

        public Receta(List<Ingrediente> ingredientes, List<string> pasos)
        {
            this.ingredientes = ingredientes;
            this.pasos = pasos;
        }

        public List<Ingrediente> Ingredientes { get => ingredientes; set => ingredientes = value; }
        public List<string> Pasos { get => pasos; set => pasos = value; }

        public bool esDeGordo(){
            return ingredientes.Sum(ingrediente=> ingrediente.Calorias)>2000;
        }
        public bool esRapida(){
            return ingredientes.Count / pasos.Count >1;
        }
    }
}