namespace E3
{
    public class DiscoHHD:Componente
    {
        float precio;

        string Sata;

        public DiscoHHD(float precio, string sata)
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