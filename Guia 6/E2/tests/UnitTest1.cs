using NUnit.Framework;
using Ejercicio;
using System.Collections.Generic;
using System.Linq;
namespace tests
{
    public class Tests
    {    
       
        List<Receta> recetas2= new List<Receta>{};
        [SetUp]
      
        public void Setup()
        {
            List<string> pasos1=new List<string>{"romper un huevo en una sarten","prender la ornalla y poner la sarten sobre la misma","esperar"};
            List<Ingrediente> ingredientes1= new List<Ingrediente>{new Ingrediente(300,"Huevo"),new Ingrediente(100,"Aceite"),new Ingrediente(0,"Sal")};
            List<string> pasos2=new List<string>{"lavar verduras","cortar verduras","mezclar"};
            List<Ingrediente> ingredientes2= new List<Ingrediente>{new Ingrediente(100,"Lechuga"),new Ingrediente(200,"Aceite"),new Ingrediente(100,"Tomate")};
            
            Receta huevoFrito= new Receta(ingredientes1,pasos1);
            Receta ensalada= new Receta(ingredientes2,pasos2);
            recetas2.Add(huevoFrito);
            recetas2.Add(ensalada);
           
            Carpe fenix= new Carpe(20);
            Mago harryPostre = new Mago(fenix,recetas2);
          
            
          
        }

        [Test]
        public void saberSiRecetasSonDeGordoFalse()
        {
            Assert.AreEqual(false,recetas2.All(receta=> receta.esDeGordo()));
        }
        [Test]
       public void saberSiHayAlgunaRecetaRapidaFalse(){
           Assert.AreEqual(false,recetas2.Any(receta=> receta.esRapida()));
       }
       [Test]
       public void saberSiHarryNoSeCuidaFalse(){
           Assert.AreEqual(false,harryPostre.noSeCuida());
       }
     [Test]
       public void saberSiHarryEsLentoFalse(){
           Assert.AreEqual(false,harryPostre.esLento());
       }
    }
}