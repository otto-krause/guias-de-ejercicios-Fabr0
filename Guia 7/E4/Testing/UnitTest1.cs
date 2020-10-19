using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
namespace testing
{
    public class Tests
    {
        Pajaros pajaroComun;
        Pajaros red;
        Pajaros bomb;
        Pajaros chuck;
        Pajaros matilda;
        List<int> huevos;
        Pajaros terence;

        List<Pajaros> pajaros;

        IslaPajaros islaPajaros;
        [SetUp]
        public void Setup()
        {

            pajaroComun = new PajarosComunes(10);
            red = new Red(10);
            bomb = new Bomb(10);
            chuck = new Chuck(90, 10);
            terence = new Terence(4, 10);
            huevos = new List<int> { 4, 6, 1, 7 };
            matilda = new Matilda(10, huevos);

            pajaros = new List<Pajaros> { pajaroComun, red, bomb, chuck, matilda, terence };

            islaPajaros= new IslaPajaros(pajaros);


        }

        [Test]
        public void fuerzaDeUnPajaroComun20()
        {
            Assert.AreEqual(20,islaPajaros.DevolverFuerza(0));
        }
 
    }
}