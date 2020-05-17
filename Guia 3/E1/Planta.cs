namespace E1
{
    public class Planta
    {
        private int uranio;
        private Empleado empleado;
        SrBurns srBurns;

        public Planta(int uranio, Empleado empleado, SrBurns srBurns)
        {
            this.uranio = uranio;
            this.empleado = empleado;
            this.srBurns = srBurns;
        }

        public bool estaEnPeligro()
        {
            return (uranio>10000 && empleado.estaDistraido())|| !srBurns.esMillonario();
        }
        public void cambiarEmpleado(Empleado nuevoEmpleado)
        {
            empleado= nuevoEmpleado;
        }
        public void cargamentoUranio(int num)
        {
            uranio+=num;
        }
    }
}