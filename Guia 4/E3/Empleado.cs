/*
Crear la clase Empleado, todos los empleados tienen una cajaBancaria, de la cuál pueden extraer o depositar.
Existen los siguientes tipos de empleados:
RRHH: cuando les depositan cobran 5000 de base más 5000 por persona referida.
Programador: cuando les depositan ganan 20000 de base más 10000 si es junior, 20000 si es semiSenior y 40000 si es senior.
Administrativo: siempre se les depositan 35000 pesos.
*/

namespace E3
{
    public abstract class Empleado
    {
        protected int cajaBancaria;

        public Empleado()
        {
            this.cajaBancaria = 0;
        }

        public virtual int Cobrar(){
            return cajaBancaria;
        }

    }
}