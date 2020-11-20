using System;
using System.Collections.Generic;

namespace Sumy
{
    class Program
    {
        static void Main(string[] args)
        {
            int liczbaTestow = int.Parse(Console.ReadLine());
            for (int i = 0; i < liczbaTestow; i++)
            {
                int n = int.Parse(Console.ReadLine());
                var listOfLists = Sumy(n);
                foreach (var item in listOfLists)
                {
                    Console.WriteLine(string.Join(" ", item));
                }
                
            }
        }

        private static List<List<int>> Sumy(int n)
        {
            var list = new List<List<int>>();
            if (n==1)
            {
                list.Add(new List<int>() { 1 });
                return list;
            }
            else
            {
                var poprzednialista = Sumy(n - 1);
                for (int i = 0; i < poprzednialista.Count; i++)
                {
                    poprzednialista[i].Add(1);
                }
                if (n%2 == 0 && n!=2)
                {
                    for (int x = 2; x <= n/2; x++)
                    {
                        if (n%x == 0)
                        {
                            var lista2 = new List<int>();
                            int iloraz = n / x;
                            for (int y = 1; y <= iloraz; y++)
                            {
                                lista2.Add(x);
                            }
                            poprzednialista.Add(lista2);
                        }
                    }
                    
                }
                else if (n % 2 == 1 && n > 3)
                {
                    for (int x = (n-1)/2; x > 1 ; x--)
                    {
                        var lista2 = new List<int>();
                        int roznica = n - x;
                        lista2.Add(x);
                        lista2.Add(roznica);
                        poprzednialista.Add(lista2);
                        
                    }
                    poprzednialista.Add(new List<int> { (n-1) / 2 , (n+1) / 2 });
                }
                poprzednialista.Add(new List<int> { n });
                foreach (var item in poprzednialista)
                {
                    item.Sort();
                }
                return poprzednialista;
            }
            
        }
    }
}
