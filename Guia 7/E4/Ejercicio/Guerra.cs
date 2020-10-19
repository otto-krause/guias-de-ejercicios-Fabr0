namespace Ejercicio
{
    public class Guerra
    {
        IslaCerdos islaCerdos;
        IslaPajaros islaPajaros;
        int numP = 0;
        int numO = 0;
        public Guerra(IslaCerdos islaCerdos, IslaPajaros islaPajaros)
        {
            this.islaCerdos = islaCerdos;
            this.islaPajaros = islaPajaros;
            numP=0;
            numO=0;
        }

        public bool pajaroDerrivarObstaculo()
        {
            return islaPajaros.DevolverFuerza(0) > islaCerdos.DevolverResistencia(0);
        }
        public void IslaPajarosAtaca()
        {
            while (islaCerdos.Obstaculos() != null || islaPajaros.Pajaros() != null)
            {
                if(islaPajaros.DevolverFuerza(numP) > islaCerdos.DevolverResistencia(numO))
                    {
                        islaCerdos.QuitarObstaculo(islaCerdos.Obstaculos()[numO]);
                        numO++;
                    }
                else
                {
                    islaPajaros.QuitarPajaro(islaPajaros.Pajaros()[numP]);
                    numP++;
                }
            } 
        }
        public bool recuperacionHuevos()
        {
            return islaCerdos.Obstaculos()==null;
        }
    }
}