using System;

namespace Task_708
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            var tablicaWynikow = new int[liczbaTestow];

            for (int i = 0; i < liczbaTestow; i++)
            {
                var s = int.Parse(Console.ReadLine());
                decimal xn = s;
                var n = 0;
                bool parzyste;
                
                while (xn!=1)
                {
                    if (xn % 2 == 0)
                    {
                        parzyste = true;
                    }
                    else parzyste = false;
                    n++;
                    if (parzyste)
                    {
                        xn /= 2;
                    }
                    else
                    {
                        xn = 3 * xn + 1;
                    }
                }
                tablicaWynikow[i] = n;
            }
            for (int i = 0; i < liczbaTestow; i++)
            {
                Console.WriteLine(tablicaWynikow[i]);
            }
        }
    }
}
