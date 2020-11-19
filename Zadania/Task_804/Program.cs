using System;

namespace Task_804
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaPartii = int.Parse(Console.ReadLine());

            var tablicaWynikow = new int[liczbaPartii];
            for (int i = 0; i < liczbaPartii; i++)
            {
                string zetony = Console.ReadLine();
                var a = int.Parse(zetony.Split(' ')[0]);
                var b = int.Parse(zetony.Split(' ')[1]);
                while (a!=b)
                {
                    if (a>b)
                    {
                        a -= b;
                    }
                    else
                    {
                        b -= a;
                    }
                }
                tablicaWynikow[i] = a+b;
            }
            for (int i = 0; i < liczbaPartii; i++)
            {
                Console.WriteLine(tablicaWynikow[i]);
            }
        }
    }
}
