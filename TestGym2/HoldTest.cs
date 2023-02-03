using GymnastikForening;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestGym2
{
    [TestClass]
    public class HoldTest
    {
        [TestMethod]
        public void BeregnTotalPris_3Børn_1000kr()
        {
            //Arrange
            Hold h1 = new Hold("Tumle22t", 2022, "Tumlinger", 500, 4);
            double expectedResult = 1000.0;

            //Act
            double actualResult= h1.BeregnTotalPris(3);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, 0.01);

        }

        [TestMethod]
        public void BeregnTotalPris_minus1Børn_0kr()
        {
            //Arrange
            Hold h1 = new Hold("Tumle22t", 2022, "Tumlinger", 500, 4);
            double expectedResult = 0;

            //Act
            double actualResult = h1.BeregnTotalPris(-1);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, 0.01);

        }

        [TestMethod]
        public void BeregnTotalPris_0Børn_0kr()
        {
            //Arrange
            Hold h1 = new Hold("Tumle22t", 2022, "Tumlinger", 500, 4);
            double expectedResult = 0;

            //Act
            double actualResult = h1.BeregnTotalPris(0);

            //Assert
            Assert.AreEqual(expectedResult, actualResult, 0.01);

        }


        [TestMethod]
        public void TilmeldDeltager_1Deltager_DeltagerAdded()
        {
            //Arrange
            Hold h1 = new Hold("Tumle22t", 2022, "Tumlinger", 500, 4);
            Deltager d1 = new Deltager("Poul Henriksen", "Vej 123", 2);
            int expectedResult = h1.DeltagerListe.Count+ 1;
            int expectedAntalBørn = 2; 
            //Act
            h1.TilmeldDeltager(d1);
            int actualResult = h1.DeltagerListe.Count;
            int actualAntalBørn = h1.AntalTilmeldte();
            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedAntalBørn, actualAntalBørn);
        }
    }
}