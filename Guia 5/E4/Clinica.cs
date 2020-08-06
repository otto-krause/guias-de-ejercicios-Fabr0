/*
Crear la clase Medico que tiene los atributos nombre, apellido, especialidad y cantidad de turnos.
Sabemos que un médico EstaDisponible cuando tiene menos de 50 turnos asignados. 
Crear la clase Clinica, que deberá tener una lista de médicos ya cargada.

El programa deberá poder asignar turnos a los pacientes, para ello el usuario ingresara la especialidad deseada
y el programa le dirá si hay algún médico disponible, en caso positivo le dirá el nombre del médico que lo atenderá, 
en caso negativo se le dirá que lo intente de nuevo más tarde.

*/
using System;
using System.Linq;
using System.Collections.Generic;

namespace E4
{
    public class Clinica
    {
        List<Medico> medicos= new List<Medico>{};

        public Clinica()
        {
            medicos.Add(new Medico("Jorge","Gonzales","Neurocirujia",12));
            medicos.Add(new Medico("Juan","Perez","Cardiologia",56));
            medicos.Add(new Medico("Jose","Lopez","Cardiologia",32));
        }

        public Medico asignarTurno(string especialidad){
           return medicos.First(medicos=> medicos.Especialidad==especialidad);
        }
    }
}