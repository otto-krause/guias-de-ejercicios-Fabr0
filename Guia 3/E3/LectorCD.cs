namespace E3
{
    public class LectorCD: Componente
    {
        float precio;

        string Sata;

        public LectorCD(float precio, string sata)
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