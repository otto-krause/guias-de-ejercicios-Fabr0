using System.Collections.Generic;
namespace Ejercicio
{
    public class IslaCerdos
    {
        List<Obstaculos> obstaculos;

        public IslaCerdos(List<Obstaculos> obstaculos)
        {
            this.obstaculos = obstaculos;
        }
        public int DevolverResistencia(int num)
        {
            return obstaculos[num].resistencia();
        }
        public void QuitarObstaculo(Obstaculos obs)
        {
            obstaculos.Remove(obs);
        }
        public List<Obstaculos> Obstaculos()
        {
            return obstaculos;
        }
     
    }
}