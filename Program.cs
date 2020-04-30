using System;
using System.Collections.Generic;

namespace RhythmBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] strum =  {"U", "D", "_"};
            List<string> pattern = new List<string>();

            
            for (int i = 0; i <= 8; i++)
            {
                int randstrum = rnd.Next(strum.Length);
                pattern.Add(strum[randstrum]);
            }
            foreach (string i in pattern)
            {
                Console.Write(i);
            }
            
        }
    }
}
