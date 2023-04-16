using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FishLibrary
{
    public class Fishes
    {
        public static List<Fish> FishList = new List<Fish>();

        public static string Info(string name)
        {
            switch (name)
            {
                case "Pollack":
                    string pollack = Pollack.maxTemp.ToString() + " " + Pollack.maxTempTime.ToString() + " " +
                        Pollack.minTemp.ToString() + " " + Pollack.minTempTime.ToString();
                    return pollack;
                case "Salmon":
                    string salmon = Salmon.maxTemp.ToString() + " " + Salmon.maxTempTime.ToString() + " " +
                        Salmon.minTemp.ToString() + " " + Salmon.minTempTime.ToString();
                    return salmon;
                default:
                    return null;
            }
        }

        public static string Fab(string name, string data, string temp)
        {
            string s;
            switch (name)
            {
                case "Pollack":
                    FishList.Add(new Pollack(data, temp));
                    if (Checking(name, temp, data) == null)
                    {
                        return null;
                    }
                    s = Checking(name, temp, data);
                    return s;
                case "Salmon":
                    FishList.Add(new Salmon(data, temp));
                    if (Checking(name, temp, data) == null)
                    {
                        return null;
                    }
                    s = Checking(name, temp, data);
                    return s;
                default:
                    return null;
            }
        }

        public static string Checking(string name, string temp, string data)
        {
            DateTime newData = DateTime.Parse(data);
            string[] newTemp = temp.Split(" ");
            int countMin = 0;
            int countMax = 0;
            string errors = "";
            string errorsTwo = "";
            switch (name)
            {
                case "Pollack":
                    for (int i = 0; i < newTemp.Length; i++)
                    {
                        if (Convert.ToInt32(newTemp[i]) > Pollack.maxTemp)
                        {
                            errors += "Время: " + newData.AddMinutes((i) * 10) + " Факт: " +  
                                    newTemp[i] + " Норма: " +  Pollack.maxTemp + ";";
                            countMax++;
                        }
                    }
                    if (countMax*10 >= Pollack.maxTempTime)
                    {
                        return errors;
                    }
                    return null;
                case "Salmon":
                    for (int i = 0; i < newTemp.Length; i++)
                    {
                        if (Convert.ToInt32(newTemp[i]) > Salmon.maxTemp)
                        {
                            errors += "Время: " + newData.AddMinutes((i) * 10) + " Факт: " + 
                                    newTemp[i] + " Норма: " + Salmon.maxTemp + ";";
                            countMax++;
                        }
                        if (Convert.ToInt32(newTemp[i]) < Salmon.minTemp)
                        {
                            errorsTwo += "Время: " + newData.AddMinutes((i) * 10) + " Факт: " + 
                                    newTemp[i] + " Норма: " + Salmon.minTemp + ";";
                            countMin++;
                        }
                    }
                    if (countMax * 10 >= Salmon.maxTempTime && countMin * 10 >= Salmon.minTempTime)
                    {
                        return errors + errorsTwo;
                    }
                    else if (countMax * 10 >= Salmon.maxTempTime)
                    {
                        return errors;
                    }
                    else if (countMin * 10 >= Salmon.minTempTime)
                    {
                        return errorsTwo;
                    }
                    return null;
                default:
                    return null;
            }
        }

        public static void Save(string path, string info, string text)
        {
            string[] str = info.Split(";");
            using (StreamWriter sw = new StreamWriter(path, false, System.Text.Encoding.Default))
            {
                sw.WriteLine(text);
                for (int i = 0; i < str.Length; i++)
                {
                    sw.WriteLine(str[i]);
                }
            }
        }
    }
}