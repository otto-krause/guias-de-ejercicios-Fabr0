namespace E3
{
    public class MemoriaRAM : Componente
    {
         float precio;
        
        string DDR4oDDR3;

        public MemoriaRAM(string dDR4oDDR3, float Precio)
        {
            this.DDR4oDDR3 = dDR4oDDR3;
            this.precio = Precio;   
        }

        public bool EsCompatible(Mother motherboard)
        {
            return (DDR4oDDR3 == motherboard.PedirDDR4oDDR3);
        }

        public float Precio()
        {
            return precio;
        }
    }
}