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
    public class Clinica
    {
        public List<Medico> medicos=new List <Medico>();
        
       public Clinica()
        {
            medicos.Add(new Medico("Jorge","Botella","Quimioterapia",63));
            medicos.Add(new Medico("Luis","Mouse","Cardiologia",20));
            medicos.Add(new Medico("Roke","Gavilan","Alergiologia",40));
        
        } 
       public void LlamarMedico(string var)
        {
             foreach (var i in medicos)
             {
                if(i.especialidad==var)
                {
                    if (i.EstaDisponible(i.turnos))
                     {
                      Console.WriteLine("El Dr."+i.nombre+" lo antendera");
                    }
               else
                {
                    Console.WriteLine("Intentelo nuevamente mas tarde");
                }
             }
        }
    }
}
}