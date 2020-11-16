using System;

namespace Task_609
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(" ");
            double r = Convert.ToDouble(arr[0]);
            double d = Convert.ToDouble(arr[1]);

            double pi = 3.141592654;
            double result = Math.Round(-1 * ((d / 2) * (d / 2) - r * r) * pi, 2);
            Console.WriteLine(result.ToString().Replace(',', '.'));
        }
    }
}
