using System;
using System.Linq;

namespace Tak_549
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = Convert.ToInt32(Console.ReadLine());
            int[] tablicaSum = new int[liczbaTestow];
            for (int i = 0; i < liczbaTestow; i++)
            {
                int ilosc = Convert.ToInt32(Console.ReadLine());
                int[] tablicaLiczb = new int[ilosc];

                string[] tablicaZnakow = Console.ReadLine().Split(" ");
                for (int j = 0; j < ilosc; j++)
                {
                    tablicaLiczb[j] = Convert.ToInt32(tablicaZnakow[j]);
                }
                tablicaSum[i] = tablicaLiczb.Sum();
            }
            for (int i = 0; i < liczbaTestow; i++)
            {
                Console.WriteLine(tablicaSum[i]);
            }
        }
    }
}
