namespace E3
{
    public class DiscoSSD :Componente
    {
          float precio;

        string Sata;

        public DiscoSSD(float precio, string sata)
        {
            this.precio = precio;
            this.Sata = sata;
        }

        public bool EsCompatible(Mother motherboard)
        {
            return (Sata == motherboard.PedirSata);
        }

        public float Precio()
        {
            return precio;
        }
    }
}