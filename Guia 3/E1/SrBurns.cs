namespace E1
{
    public class SrBurns
    {
        private bool tieneRiquezas;

        public SrBurns()
        {
            this.tieneRiquezas = true;
        }

        public bool esMillonario()
        {
            return tieneRiquezas;
        }
        public void despojarRiquezas()
        {
            tieneRiquezas=false;
        }
    }
}