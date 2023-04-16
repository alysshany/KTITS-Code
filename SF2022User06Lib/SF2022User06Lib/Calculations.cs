using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User06Lib
{
    public class Calculations
    {
        public string[] AvailablePeriods(TimeSpan[] startTimes, int[] duration, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            TimeSpan time = beginWorkingTime;

            List<string> freeTime = new List<string>();

            int i = 0;

            while (time < endWorkingTime && time.Add(new TimeSpan(0, consultationTime, 0)) <= endWorkingTime)
            {
                if (i < duration.Length)
                {
                    var intersectionFrom = startTimes[i] > time ? startTimes[i] : time; 
                    var intersectionTo = startTimes[i].Add(new TimeSpan(0, duration[i], 0)) < time.Add(new TimeSpan(0, consultationTime, 0)) ? startTimes[i].Add(new TimeSpan(0, duration[i], 0)) : time.Add(new TimeSpan(0, consultationTime, 0)); 

                    if (intersectionFrom >= intersectionTo)
                    {
                        freeTime.Add($"{time.ToString("hh\\:mm")}-{time.Add(new TimeSpan(0, consultationTime, 0)).ToString("hh\\:mm")}");

                        time = time.Add(new TimeSpan(0, consultationTime, 0));
                    }
                    else
                    {
                        time = startTimes[i].Add(new TimeSpan(0, duration[i], 0));

                        i++;
                    }
                }
                else
                {
                    freeTime.Add($"{time.ToString("hh\\:mm")}-{time.Add(new TimeSpan(0, consultationTime, 0)).ToString("hh\\:mm")}");

                    time = time.Add(new TimeSpan(0, consultationTime, 0));
                }
            }

            return freeTime.ToArray();
        }
    }
}
