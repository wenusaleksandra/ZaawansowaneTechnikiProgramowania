using System;
using System.Collections.Generic;

namespace Task_663
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = Convert.ToInt32(Console.ReadLine());

            var listaPunktow = new List<KeyValuePair<string, double>>[liczbaTestow];
            for (int i = 0; i < liczbaTestow; i++)
            {
                int liczbaPuntow = Convert.ToInt32(Console.ReadLine());
                var test = new List<KeyValuePair<string, double>>();
                for (int j = 0; j < liczbaPuntow; j++)
                {
                    var punkt = Console.ReadLine();
                    var x = Convert.ToInt32(punkt.Split(' ')[1]);
                    var y = Convert.ToInt32(punkt.Split(' ')[2]);

                    var odleglosc = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                    test.Add(new KeyValuePair<string, double>(punkt, odleglosc));
                }
                listaPunktow[i] = test;
                Console.ReadLine();
            }
            for (int i = 0; i < liczbaTestow; i++)
            {
                listaPunktow[i].Sort((a, b) => a.Value.CompareTo(b.Value));
                foreach (var pair in listaPunktow[i])
                {
                    Console.WriteLine(pair.Key);
                }
                Console.WriteLine("");
            }
        }
    }
}
