using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
namespace tests
{
    public class Tests
    {
        Kingpin kingpin;
        Arma laser;
        Arma telaraña;
        Traje TsiderNoir;
        Traje Tspidermans;
        SpiderGwen gwen;
        MilesMorales milesMorales;
        PeterParker spiderman;
        SpidermanNoir noir;
        SpiderTeam spiderTeam;
        [SetUp]
        public void Setup()
        {
            laser= new Arma(10,"Acme");
            telaraña= new Arma(20,"Casero");
            
            TsiderNoir= new Traje(40,new List<Arma>{laser,telaraña});
            Tspidermans= new Traje(68, new List<Arma>{telaraña});

            gwen= new SpiderGwen(6,20,Tspidermans);
            milesMorales= new MilesMorales(20,40,Tspidermans);
            spiderman = new PeterParker(30,Tspidermans);
            noir= new SpidermanNoir(24,TsiderNoir);

            kingpin= new Kingpin();

            spiderTeam= new SpiderTeam(new List<Spiderman>{gwen,milesMorales,spiderman,noir});

        }

        [Test]
        public void FuerzaSpiderteam114()
        {
            Assert.AreEqual(114,spiderTeam.fuerzaSpiderEquipo());
        }
        [Test]
        public void SumaPoder244()
        {
            Assert.AreEqual(244,spiderTeam.poderSpiderEquipo());
        }
        [Test]
        public void ()
        {
            Assert.AreEqual(244,spiderTeam.poderSpiderEquipo());
        }      
    }
}