using System;
/*Una empresa constructora tiene un listado de contratistas a los que acude a la hora de realizar una construcción. 
Todos los contratistas entienden los siguientes mensajes:
Trabajar: que recibe la cantidad de horas que trabajó.
Cobrar: que devuelve cuánto cobrará el contratista luego de finalizado el trabajo.
	Existen tres tipo de contratistas:
Pintores: Cada una hora de trabajo gastan alrededor de 3 litros de pintura. Y cobran 50 pesos por cada litro de pintura gastado.
Plomeros: Cobran 80 pesos por hora de trabajo.
Albañiles: Dependiendo de su edad, pueden cobrar más o menos, si tienen entre 20 y 30 años cobran 50 la hora, 
si tienen entre 30 y 50 años cobran 90 la hora y si tienen más de 50 años cobran 120 la hora.
 Además, cobran 50 pesos adicionales si tienen título de MMO.
Crear un programa en el que hayan 15 contratistas ya cargados. La constructora planea ingresar un presupuesto 
y una cantidad de horas de trabajo para la realización de un edificio, cuando ejecuten el programa,
 esta deberá decirles si el presupuesto ingresado les alcanza para llevar a cabo el proyecto.

 contratista(interfaz?)
 clases(pintor,plomero,albañil) constructora
*/
namespace E2
{
    public class Plomero :Contrarista
    {
        int horasTrabajadas;
        int sueldo;

        public Plomero()
        {
            this.horasTrabajadas =0;
            this.sueldo = 80;
        }

        public void Trabajar(int num)
        {
            horasTrabajadas=num;
        }
        public int Cobrar()
        {
            return horasTrabajadas*sueldo;
        }
    }
}