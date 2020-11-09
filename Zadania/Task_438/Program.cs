using System;

namespace Task_438
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj liczbę przypadków do rozważenia");
            int D = int.Parse(Console.ReadLine());
            int[] podstawy = new int[D];
            int[] wykladniki = new int[D];

            for (int i = 0; i < D; i++)
            {
                var input = Console.ReadLine();
                var comaPosition = input.IndexOf(' ');
                int a = int.Parse(input.Substring(0, comaPosition));
                podstawy[i] = a;
                int b = int.Parse(input.Substring(comaPosition + 1, input.Length - comaPosition - 1));
                wykladniki[i] = b;
            }

            for (int i = 0; i < D; i++)
            {
               var cyfraJednosciPodstawy = podstawy[i] % 10;
                if (cyfraJednosciPodstawy == 1)
                {
                    Console.WriteLine("1");
                }
            }
        }
    }
}
