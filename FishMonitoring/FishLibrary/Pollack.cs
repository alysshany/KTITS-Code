using System;
using System.Collections.Generic;
using System.Text;

namespace FishLibrary
{
    class Pollack : Fish
    {
        public static int maxTemp = -5;
        public static int? minTemp = null;
        public static int maxTempTime = 20;
        public static int? minTempTime = null;

        public Pollack(string data, string temp)
        {
            base.dataFish = data;
            base.tempFish = temp;
        }
    }
}
