using Microsoft.VisualStudio.TestTools.UnitTesting;
using SF2022User06Lib;
using System;

namespace SF2022User06Test
{
    [TestClass]
    public class CalculationsTest
    {
        [TestMethod]
        public void CalculationsTestOneMain_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(10,70,0),
                new TimeSpan(11,0,0),
                new TimeSpan (15,0,0),
                new TimeSpan(15,30,0),
                new TimeSpan (16,50,0)
            };

            int[] durations = new int[]
            {
                60, 30, 10, 10, 40
            };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 30;

            string[] time = new string[]
            {
                "08:00-08:30",
                "08:30-09:00",
                "09:00-09:30",
                "09:30-10:00",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:00-13:30",
                "13:30-14:00",
                "14:00-14:30",
                "14:30-15:00",
                "15:40-16:10",
                "16:10-16:40",
                "17:30-18:00"
            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestTwoWithConsultationTime30And5StartTimes_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(8,0,0),
                new TimeSpan(10,10,0),
                new TimeSpan (15,0,0),
                new TimeSpan(15,30,0),
                new TimeSpan (17,30,0)
            };

            int[] durations = new int[]
            {
                40, 20, 10, 10, 30
            };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 30;

            string[] time = new string[]
            {
                "08:40-09:10",
                "09:10-09:40",
                "09:40-10:10",
                "10:30-11:00",
                "11:00-11:30",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:00-13:30",
                "13:30-14:00",
                "14:00-14:30",
                "14:30-15:00",
                "15:40-16:10",
                "16:10-16:40",
                "16:40-17:10"
            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestThreeWithConsultationTime30AndNearlyAllStartTimes_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(8,0,0),
                new TimeSpan(9,20,0),
                new TimeSpan (10,10,0),
                new TimeSpan (10,30,0),
                new TimeSpan (11,50,0),
                new TimeSpan (13,00,0),
                new TimeSpan (14,10,0),
                new TimeSpan (14,50,0),
                new TimeSpan(16,00,0),
                new TimeSpan(16,30,0),
                new TimeSpan (17,30,0)
            };

            int[] durations = new int[]
            {
                40, 30, 10, 60, 60, 40, 20, 60, 30, 60, 30
            };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 30;

            string[] time = new string[]
            {
                "08:40-09:10",
                "13:40-14:10"
            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestFourWithConsultationTime30AndAllBusyTime_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(8,0,0),
                new TimeSpan(8,40,0),
                new TimeSpan(9,20,0),
                new TimeSpan (10,10,0),
                new TimeSpan (10,30,0),
                new TimeSpan (11,50,0),
                new TimeSpan (13,00,0),
                new TimeSpan (13,40,0),
                new TimeSpan (14,10,0),
                new TimeSpan (14,50,0),
                new TimeSpan(16,00,0),
                new TimeSpan(16,30,0),
                new TimeSpan (17,30,0)
            };

            int[] durations = new int[]
            {
                40, 30, 30, 10, 60, 60, 40, 30, 20, 60, 30, 60, 30
            };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 30;

            string[] time = new string[]
            {

            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestFiveWithConsultationTime30AndNoStartTimes_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {

            };

            int[] durations = new int[]
            {
                
            };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 30;

            string[] time = new string[]
            {
                "08:00-08:30",
                "08:30-09:00",
                "09:00-09:30",
                "09:30-10:00",
                "10:00-10:30",
                "10:30-11:00",
                "11:00-11:30",
                "11:30-12:00",
                "12:00-12:30",
                "12:30-13:00",
                "13:00-13:30",
                "13:30-14:00",
                "14:00-14:30",
                "14:30-15:00",
                "15:00-15:30",
                "15:30-16:00",
                "16:00-16:30",
                "16:30-17:00",
                "17:00-17:30",
                "17:30-18:00",
            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestSixWithConsultationTime60_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(8,20,0),
                new TimeSpan(10,10,0),
                new TimeSpan (12,50,0),
                new TimeSpan(14,30,0),
                new TimeSpan (16,00,0)
            };

            int[] durations = new int[]
            {
                30, 20, 30, 10, 120
            };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 60;

            string[] time = new string[]
            {
                "08:50-09:50",
                "10:30-11:30",
                "11:30-12:30",
                "13:20-14:20",
                "14:40-15:40",
            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestSevenWithConsultationTime50_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(9,20,0),
                new TimeSpan(12,50,0),
                new TimeSpan(14,30,0),
                new TimeSpan(16,10,0),
            };

            int[] durations = new int[]
            {
                30, 20, 30, 10
            };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 50;

            string[] time = new string[]
            {
                "08:00-08:50",
                "09:50-10:40",
                "10:40-11:30",
                "11:30-12:20",
                "13:10-14:00",
                "15:00-15:50",
                "16:20-17:10",
                "17:10-18:00"

            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestEightWithConsultationTime40_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(8,0,0),
                new TimeSpan(9,20,0),
                new TimeSpan (10,30,0),
                new TimeSpan (11,50,0),
                new TimeSpan (13,40,0),
                new TimeSpan (14,50,0),
                new TimeSpan(16,00,0),
                new TimeSpan (17,30,0)
            };

            int[] durations = new int[]
            {
                40, 30, 30, 10, 60, 60, 40, 30
            };

            TimeSpan beginWorkingTime = new TimeSpan(8, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 40;

            string[] time = new string[]
            {
                "08:40-09:20",
                "09:50-10:30",
                "11:00-11:40",
                "12:00-12:40",
                "12:40-13:20",
                "16:40-17:20"

            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestNineWithConsultationTime40From14Hours_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan (14,50,0),
                new TimeSpan(16,00,0),
                new TimeSpan (17,30,0)
            };

            int[] durations = new int[]
            {
                60, 40, 30
            };

            TimeSpan beginWorkingTime = new TimeSpan(14, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 40;

            string[] time = new string[]
            {
                "14:00-14:40",
                "16:40-17:20"

            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }

        [TestMethod]
        public void CalculationsTestTenWithOnlyOneStartTime_time_time2Returned()
        {
            Calculations calculations = new Calculations();

            TimeSpan[] startTimes = new TimeSpan[]
            {
                new TimeSpan(16,00,0)
            };

            int[] durations = new int[]
            {
                60
            };

            TimeSpan beginWorkingTime = new TimeSpan(14, 0, 0);
            TimeSpan endWorkingTime = new TimeSpan(18, 0, 0);

            int consultationTime = 30;

            string[] time = new string[]
            {
                "14:00-14:30",
                "14:30-15:00",
                "15:00-15:30",
                "15:30-16:00",
                "17:00-17:30",
                "17:30-18:00"

            };

            string[] time2 = calculations.AvailablePeriods(startTimes, durations, beginWorkingTime, endWorkingTime, consultationTime);

            CollectionAssert.AreEquivalent(time, time2);

        }
    }
}
