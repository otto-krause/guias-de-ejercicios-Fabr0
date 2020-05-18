namespace E3
{
    public class PlacaVideo : Componente
    {
        float precio;

        string PCIE;

        public PlacaVideo(float precio, string pCIE)
        {
            this.precio = precio;
            this.PCIE = pCIE;
        }

        public bool EsCompatible(Mother motherboard)
        {
            return PCIE == motherboard.PedirPCIE;
        }

        public float Precio()
        {
            return precio;  
        }
    }
}