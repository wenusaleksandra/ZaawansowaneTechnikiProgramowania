using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;

namespace Task_522
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ile zestawów przygotować");
            int zestawy = Convert.ToInt32(Console.ReadLine());
            for(var i =0; i< zestawy; i++)
            {
                Console.Clear();
                Console.WriteLine("Podaj wielkości grup (oddzielone spacją)");
                string value = Console.ReadLine();
                int grupa1 = Convert.ToInt32(value.Split(" ")[0]);
                int grupa2 = Convert.ToInt32(value.Split(" ")[1]);

                var rozklad1 = Rozloz(grupa1);
                var rozklad2 = Rozloz(grupa2);

                var dzielniki1 = rozklad1.Select(x => x.Key).ToList();
                var dzielniki2 = rozklad2.Select(x => x.Key).ToList();
                var unique = dzielniki1.Concat(dzielniki2).Distinct().ToList();
                List<int> dest = new List<int>();
                foreach(int o in unique)
                {
                    var d1Count = dzielniki1.Count(x => x == o);
                    var d2Count = dzielniki2.Count(x => x == o);
                    for(var s =0; s< Math.Max(d1Count, d2Count); s++)
                    {
                        dest.Add(o);
                    }
                }
                var nww = 1;
                foreach (int j in dest)
                {
                    Console.WriteLine(j);
                    nww = j * nww;
                }
                Console.WriteLine($"Potrzeba {nww} cukierków");
            }
        }

        public static List<int> Get_LiczbyPierwsze(int max)
        {
            List<int> liczby = new List<int>();
            for (var i = 2; i <= max; i++) liczby.Add(i);
            return liczby.Where(x => JestPierwsza(x)).ToList();
        }

        public static bool JestPierwsza(int liczba)
        {
            int c = liczba;
            for(var i=2; i<liczba; i++)
            {
                if (liczba % i == 0) return false;
            }
            return true;
        }

        public static List<KeyValuePair<int, int>> Rozloz(int liczba)
        {
            List<int> pierwsze = Get_LiczbyPierwsze(liczba);
            List<KeyValuePair<int, int>> output = new List<KeyValuePair<int, int>>();

            do
            {
                int warunkowa = output.Count() == 0 ? liczba : output.Last().Value;
                int dzielnik = MinPierwsza(pierwsze, warunkowa);
                output.Add(new KeyValuePair<int, int>(dzielnik, warunkowa / dzielnik));
            } while (output.Last().Value != 1);

            return output;

        }

        public static int MinPierwsza(List<int> pierwsze, int num)
        {
            foreach(int p in pierwsze)
            {
                if (num % p == 0) return p;
            }
            return num;
        }
    }
}
