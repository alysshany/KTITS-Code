using System;
using System.IO;

namespace ParsingLibrary
{
    public class Parsing
    {
        public static string Parse(string path)
        {
            string infoTemp = "";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                int i = 1;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    if (i % 2 == 0)
                    {
                        infoTemp += line;
                    }
                    else
                    {
                        infoTemp += line + ";";
                    }
                    i++;
                }
            }
            return infoTemp;
        }
    }
}
