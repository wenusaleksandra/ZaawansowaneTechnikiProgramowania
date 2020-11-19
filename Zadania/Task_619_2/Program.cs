using System;

namespace Task_619
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());

            var tablicaWynikow = new string[liczbaTestow];

            for (int i = 0; i < liczbaTestow; i++)
            {
                float liczba = float.Parse(Console.ReadLine().Replace('.', ','));
                string wynik = BitConverter.ToString(BitConverter.GetBytes(liczba));
                string[] tab = wynik.Split('-');
                wynik = "";
                for (int j = tab.Length - 1; j >= 0; j--)
                {
                    if (tab[j][0] == '0')
                    {
                        wynik += tab[j][1];
                    }
                    else
                    {
                        wynik += tab[j];
                    }

                    if (j > 0)
                    {
                        wynik += " ";
                    }
                }
                tablicaWynikow[i] = wynik;
                Console.WriteLine(wynik.ToLower());
            }
            for (int i = 0; i < liczbaTestow; i++)
            {
                Console.WriteLine(tablicaWynikow[i].ToLower());
            }
        }
    }
}
