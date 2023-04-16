using System;
using System.Collections.Generic;
using System.Text;

namespace FishLibrary
{
    class Salmon : Fish
    {
        public static int maxTemp = 5;
        public static int minTemp = -3;
        public static int maxTempTime = 20;
        public static int minTempTime = 60;

        public Salmon(string data, string temp)
        {
            base.dataFish = data;
            base.tempFish = temp;
        }
    }
}
