using System;

namespace Task_626
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = Convert.ToInt32(Console.ReadLine());
            int[] iloscPudelek = new int[liczbaTestow];
            for (int i = 0; i < liczbaTestow; i++)
            {
                var dane = Console.ReadLine();
                var liczbaObzartuchow = Convert.ToInt32(dane.Split(' ')[0]);
                var liczbaCiastekWPudelku = Convert.ToInt32(dane.Split(' ')[1]);
                decimal iloscCiastekNaDobe = 0;
                for (int j = 0; j < liczbaObzartuchow; j++)
                {
                    var czasWSekundach = Convert.ToDecimal(Console.ReadLine());
                    iloscCiastekNaDobe += Math.Truncate(24 * 3600 / czasWSekundach);
                }
                iloscPudelek[i] = Convert.ToInt32(Math.Ceiling(iloscCiastekNaDobe / liczbaCiastekWPudelku));
            }
            for (int i = 0; i < liczbaTestow; i++)
            {
                Console.WriteLine(iloscPudelek[i]);
            }
        }
    }
}
