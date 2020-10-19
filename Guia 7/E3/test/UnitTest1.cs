using NUnit.Framework;
using System.Collections.Generic;
using Ejercicio;

namespace test
{
    public class Tests
    {
        Tecnologia gancho;
        Tecnologia gas;

        Tecnologia batarang;
        List<Tecnologia> baticinturon;

        Villano superman;

        Villano joker;

        Villano catwoman;
        List<Villano> villanos;
        Batman batman;
        [SetUp]

        public void Setup()
        {
            gancho = new Tecnologia("Batigancho", 200, 5);
            gas = new Tecnologia("Batigas lacrimogeno", 500, 1);
            batarang = new Tecnologia("Batarang", 700, 1);

            baticinturon = new List<Tecnologia> { gancho, gas, batarang };

            batman = new Batman(baticinturon);

            joker = new Psicopata(2, 100000);

            catwoman = new GuanteBlanco();

            superman = new Extraterrestre(4, 5, 1);

            villanos = new List<Villano> { joker, superman, catwoman };

        }

        [Test]
        public void EstaEstresadoBatmanTrue()
        {
            Assert.AreEqual(false, batman.estaEstresado());
        }
        [Test]
        public void VidaBatman800()
        {
            Assert.AreEqual(800, batman.Vida);
        }
        [Test]

        public void CombaritCrimenVidaBatman600()
        {
            batman.combatirCrimen(villanos);
            Assert.AreEqual(600, batman.Vida);
        }
        [Test]

        public void batiTwist900()
        {
            batman.batiTwist();
            Assert.AreEqual(900, batman.Vida);
        }
        [Test]
        public void BatmanAlaModafalse()
        {
            Assert.AreEqual(false, batman.estaDeModa());//ctrl+k+c comentar una linea ctrl+k+u descomentarla
        }
        // }
        // public void GoticaLujosa()
        // {

        // }

    }
}