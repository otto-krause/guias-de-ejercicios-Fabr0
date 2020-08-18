using NUnit.Framework;
using teenTitans;
namespace Testing
{
    public class Tests
    {
        private Arma bastonDeMetal;

        [SetUp]
        public void Setup()
        {
            bastonDeMetal= new Arma(15,10);
        }

        [Test]
        public void TestElCalculoFibonacciDelBastonDeMetalEs610()
        {
            Assert.AreEqual(610,bastonDeMetal.fibonacci());//assert sirve para provar acorde lo que queremos, areequal(a,b)
        }
    }
}