using NUnit.Framework;
using System.Collections.Generic;
using Ejercicio;

namespace test
{
    public class Tests
    {
        Heroe endevaror;

        Quirk hellFlame;
        Quirk quirkVillano1;
        Quirk quirkVillano2;

        Villano muyMalote;
        Villano muyMalote2;

        List<Villanos> villanos;
        [SetUp]

        public void Setup()
        {
            hellFlame= new Quirk("Hell Flame",300,"");
            quirkVillano1= new Quirk("Malisimo 1",120,"Demencia");
            quirkVillano2= new Quirk("Malisimo 2",40,"");

            endevaror= new Heroe(200,50,hellFlame);
            muyMalote= new Villano(quirkVillano1,true,false,true);//quirk,roboenonce,trabajo,pizzaconpiña
            muyMalote2= new Villano(quirkVillano2,true,true,false);

            villanos = new List<Villano> {muyMalote,muyMalote2};

        }

        [Test]
        public void esMuyMalotruefalse ()
        {
            Assert.AreEqual(false, muyMalote.esMuyMalo());
        }
        
    }
}