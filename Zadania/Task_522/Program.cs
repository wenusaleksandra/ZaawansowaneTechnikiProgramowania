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
                var g1 = grupa1;
                var g2 = grupa2;
                while(grupa1 != grupa2)
                {
                    if(grupa1 < grupa2)
                    {
                        grupa1 += g1;
                    }
                    else
                    {
                        grupa2 += g2;
                    }
                }
                Console.Clear();
                Console.WriteLine(grupa1);
            }
        }
    }
}
