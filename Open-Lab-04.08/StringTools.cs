using System;

namespace Open_Lab_04._08
{
    public class StringTools
    {
        public string[] IsFourLetters(string[] strings)
        {
            int a = 0;
            int b = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i].Length == 4)
                {
                    a = a + 1;  
                }
            }
            string[] vysledokstrings = new string[a];
            for (int ii = 0; ii < strings.Length; ii++)
            {
                if (strings[ii].Length == 4)
                {
                    vysledokstrings[b] = strings[ii];
                    b = b + 1;
                }
            }
            return vysledokstrings;
        }
    }
}
