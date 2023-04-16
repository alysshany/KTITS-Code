using AirplaneClassLibrary;
using AirportClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace AirplaneUnitTest
{
    [TestClass]
    public class AirplaneTest
    {
        [TestMethod]
        public void GettingAirplanesFromThisHourTestOne()
        {
            Airport airoport = new Airport();
            airoport.AddingAirplane(new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)));
            airoport.AddingAirplane(new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)));
            airoport.AddingAirplane(new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 4, 19, 04, 0, 0)));
            airoport.AddingAirplane(new Airplane("Сочи", "IB7270", new DateTime(2020, 2, 5, 13, 24, 0, 0)));
            airoport.AddingAirplane(new Airplane("Пермь", "AB5962", new DateTime(2020, 2, 5, 14, 07, 0, 0)));

            List<Airplane> airplaneListExpected = new List<Airplane>() 
            { 
                new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)),
                new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0))
            };

            List<Airplane> airplaneListActual = airoport.GettingAirplanesFromThisHour(new DateTime(2020, 2, 3, 18, 0, 0, 0));
            

            CollectionAssert.AreEquivalent(airplaneListExpected, airplaneListActual);
        }

        [TestMethod]
        public void GettingAirplanesFromThisHourTestTwo()
        {
            Airport airoport = new Airport();
            airoport.AddingAirplane(new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)));
            airoport.AddingAirplane(new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)));
            airoport.AddingAirplane(new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 4, 19, 04, 0, 0)));
            airoport.AddingAirplane(new Airplane("Сочи", "IB7270", new DateTime(2020, 2, 5, 13, 24, 0, 0)));
            airoport.AddingAirplane(new Airplane("Пермь", "AB5962", new DateTime(2020, 2, 5, 14, 07, 0, 0)));

            List<Airplane> airplaneListExpected = new List<Airplane>()
            {

            };

            List<Airplane> airplaneListActual = airoport.GettingAirplanesFromThisHour(new DateTime(2020, 2, 6, 05, 12, 0, 0));


            CollectionAssert.AreEquivalent(airplaneListExpected, airplaneListActual);
        }

        [TestMethod]
        public void GettingAiplanesGoingToPointNameTestOne()
        {
            Airport airoport = new Airport();
            airoport.AddingAirplane(new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)));
            airoport.AddingAirplane(new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)));
            airoport.AddingAirplane(new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 4, 19, 04, 0, 0)));
            airoport.AddingAirplane(new Airplane("Сочи", "IB7270", new DateTime(2020, 2, 5, 13, 24, 0, 0)));
            airoport.AddingAirplane(new Airplane("Пермь", "AB5962", new DateTime(2020, 2, 5, 14, 07, 0, 0)));

            List<Airplane> airplaneListExpected = new List<Airplane>()
            {
                new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0))
            };

            List<Airplane> airplaneListActual = airoport.GettingAiplanesGoingToPointName("Казань");
            CollectionAssert.AreEquivalent(airplaneListExpected, airplaneListActual);
        }

        [TestMethod]
        public void GettingAiplanesGoingToPointNameTestTwo()
        {
            Airport airoport = new Airport();
            airoport.AddingAirplane(new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)));
            airoport.AddingAirplane(new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)));
            airoport.AddingAirplane(new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 4, 19, 04, 0, 0)));
            airoport.AddingAirplane(new Airplane("Сочи", "IB7270", new DateTime(2020, 2, 5, 13, 24, 0, 0)));
            airoport.AddingAirplane(new Airplane("Пермь", "AB5962", new DateTime(2020, 2, 5, 14, 07, 0, 0)));

            List<Airplane> airplaneListExpected = new List<Airplane>()
            {

            };

            List<Airplane> airplaneListActual = airoport.GettingAiplanesGoingToPointName("Красноярск");
            CollectionAssert.AreEquivalent(airplaneListExpected, airplaneListActual);
        }

        [TestMethod]
        public void AddingNewAirplane()
        {
            Airport airoport = new Airport();
            airoport.AddingAirplane(new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)));
            airoport.AddingAirplane(new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)));

            List<Airplane> airplaneListExpected = new List<Airplane>()
            {
                new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)),
                new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)),
                new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 19, 04, 0, 0, 0))
            };

            airoport.AddingAirplane(new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 19, 04, 0, 0, 0)));
            CollectionAssert.AreEquivalent(airplaneListExpected, airoport.GettingAirplaneList());
        }

        [TestMethod]
        public void GettingAirplaneFromIndex()
        {
            Airport airoport = new Airport();
            airoport.AddingAirplane(new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)));
            airoport.AddingAirplane(new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)));
            airoport.AddingAirplane(new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 4, 19, 04, 0, 0)));
            airoport.AddingAirplane(new Airplane("Сочи", "IB7270", new DateTime(2020, 2, 5, 13, 24, 0, 0)));
            airoport.AddingAirplane(new Airplane("Пермь", "AB5962", new DateTime(2020, 2, 5, 14, 07, 0, 0)));

            Airplane airplaneListExpected = new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 4, 19, 04, 0, 0));
            
            Airplane airplaneFind = airoport.GettingAirplaneInfoFromIndex(2);

            Assert.AreEqual(airplaneListExpected, airplaneFind);
        }

        [TestMethod]
        public void GettingAirplaneList()
        {
            Airport airoport = new Airport();
            airoport.AddingAirplane(new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)));
            airoport.AddingAirplane(new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)));
            airoport.AddingAirplane(new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 4, 19, 04, 0, 0)));
            airoport.AddingAirplane(new Airplane("Сочи", "IB7270", new DateTime(2020, 2, 5, 13, 24, 0, 0)));
            airoport.AddingAirplane(new Airplane("Пермь", "AB5962", new DateTime(2020, 2, 5, 14, 07, 0, 0)));

            List<Airplane> airplaneListExpected = new List<Airplane>()
            {
                new Airplane("Москва", "KJ6789", new DateTime(2020, 2, 3, 18, 27, 0, 0)),
                new Airplane("Казань", "SU3567", new DateTime(2020, 2, 3, 18, 56, 0, 0)),
                new Airplane("Севастополь", "LY8985", new DateTime(2020, 2, 4, 19, 04, 0, 0)),
                new Airplane("Сочи", "IB7270", new DateTime(2020, 2, 5, 13, 24, 0, 0)),
                new Airplane("Пермь", "AB5962", new DateTime(2020, 2, 5, 14, 07, 0, 0))
            };

            List<Airplane> airplaneListActual = airoport.GettingAirplaneList();

            CollectionAssert.AreEquivalent(airplaneListExpected, airplaneListActual);
        }
    }
}
