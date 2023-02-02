using Microsoft.VisualStudio.TestTools.UnitTesting;
using GymnastikForening;
using System;

namespace TestGym
{
    [TestClass]
    public class HoldTest
    {
        [TestMethod]
        public void BeregnTotalPris_3b�rn_1000kr()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            Deltager d1 = new Deltager("Magrethe Frederiksen", "Gade 123, 4000 Roskilde", 3);
            double forventetPris = 1000.0;

            //Act
            double aktuelPris = hold.BeregnTotalPris(d1.AntalB�rn);

            

            //Assert
            Assert.AreEqual(forventetPris, aktuelPris, 0.01);

        }

        [TestMethod]
        public void BeregnTotalPris_1barn_500kr()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            Deltager d1 = new Deltager("Magrethe Frederiksen", "Gade 123, 4000 Roskilde", 1);
            double forventetPris = 500.0;
            //Act
            double aktuelPris = hold.BeregnTotalPris(d1.AntalB�rn);

            //Assert
            Assert.AreEqual(forventetPris, aktuelPris, 0.01);

        }

        [TestMethod]
        public void BeregnTotalPris_0b�rn_0kr()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            int antalB�rn = 0;
            double forventetPris = 0.0;
            //Act
            double aktuelPris = hold.BeregnTotalPris(antalB�rn);

            //Assert
            Assert.AreEqual(forventetPris, aktuelPris, 0.01);
        }

        [TestMethod]
        public void BeregnTotalPris_Minus1b�rn_0kr()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            int antalB�rn = -1;
            double forventetPris = 0.0;
            //Act
            double aktuelPris = hold.BeregnTotalPris(antalB�rn);

            //Assert
            Assert.AreEqual(forventetPris, aktuelPris, 0.01);
        }

        [TestMethod]
        public void BeregnTotalPris_15b�rn_0kr()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            int antalB�rn = 15;
            double forventetPris = hold.PrisPrDeltager + (antalB�rn-1)* hold.PrisPrDeltager * 50/100;
            //Act
            double aktuelPris = hold.BeregnTotalPris(antalB�rn);

            //Assert
            Assert.AreEqual(forventetPris, aktuelPris, 0.01);
        }

        [TestMethod]
        public void TilmeldDeltager_2DeltagereIalt4B�rn_4B�rn()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            Deltager d1 = new Deltager("Magrethe Frederiksen", "Gade 123, 4000 Roskilde", 3);
            Deltager d2 = new Deltager("Peter Jensen", "vej 321, 4000 Roskilde", 1);
            int forventetAntaldeltagere = 4;
            //Act
            hold.TilmeldDeltager(d1);
            hold.TilmeldDeltager(d2);
            int antalDeltager = hold.AntalTilmeldte();

            //Assert
            Assert.AreEqual(forventetAntaldeltagere, antalDeltager);

        }

        [TestMethod]
        public void TilmeldDeltager_1DeltagereIalt0B�rn_0B�rn()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            Deltager d1 = new Deltager("Magrethe Frederiksen", "Gade 123, 4000 Roskilde", 0);
            int forventetAntaldeltagere = 0;
            //Act
            hold.TilmeldDeltager(d1);
            
            int antalDeltager = hold.AntalTilmeldte();

            //Assert
            Assert.AreEqual(forventetAntaldeltagere, antalDeltager);

        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TilmeldDeltager_1DeltagereIaltminusB�rn_ArgumentException()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            Deltager d1 = new Deltager("Magrethe Frederiksen", "Gade 123, 4000 Roskilde", -1);
            
            //Act
            hold.TilmeldDeltager(d1);

            //Assert            

        }

        [TestMethod]
        public void TilmeldDeltager_1DeltagereIalt5B�rn_5B�rn()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            Deltager d1 = new Deltager("Magrethe Frederiksen", "Gade 123, 4000 Roskilde", 5);
            int forventetAntaldeltagere = 5;
            //Act
            hold.TilmeldDeltager(d1);
            int antalDeltager = hold.AntalTilmeldte();
            //Assert            
            Assert.AreEqual(forventetAntaldeltagere, antalDeltager);
        }

        [TestMethod]
        [ExpectedException(typeof(FuldtHoldException))]
        public void TilmeldDeltager_1DeltagereIalt6B�rn_FuldtHoldException()
        {
            //Arrange
            Hold hold = new Hold("TumlingE22", 2022, "Musik for tumlinger", 500, 5);
            Deltager d1 = new Deltager("Magrethe Frederiksen", "Gade 123, 4000 Roskilde", 6);

            //Act
            hold.TilmeldDeltager(d1);

            //Assert            

        }
    }
}