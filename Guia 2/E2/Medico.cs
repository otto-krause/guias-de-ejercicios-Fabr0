using System;
using System.Collections.Generic;
/*2) Crear la clase Medico que tiene los atributos nombre, apellido, especialidad y cantidad de turnos. 
Sabemos que un médico EstaDisponible cuando tiene menos de 50 turnos asignados. 
Crear la clase Clinica, que deberá tener una lista de médicos ya cargada.

El programa deberá poder asignar turnos a los pacientes,
 para ello el usuario ingresara la especialidad deseada y el programa le dirá si hay algún médico disponible,
  en caso positivo le dirá el nombre del médico que lo atenderá, en caso negativo se le dirá que lo intente de nuevo más tarde.
*/
namespace E2
{
    public class Medico
    {
        public string nombre;
        string apellido;
        public string especialidad;
        public int turnos;
        public Medico(string nombre,string apellido, string especialidad, int turnos)
        {
            this.nombre=nombre;
            this.apellido=apellido;
            this.especialidad=especialidad;
            this.turnos=turnos;
        }
        public Boolean EstaDisponible(int turnos)
        {
            return turnos<50;
        }
    }
}