using System;

namespace Task_606
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < t; i++)
            {
                string input = Console.ReadLine().Substring(2);
                string[] arr = input.Split(' ');
                for (int j = arr.Length - 1; j >= 0; j--)
                {
                    Console.Write(arr[j] + " ");
                }
                Console.WriteLine();

                //string input = Console.ReadLine();
                //int n = int.Parse(input[0].ToString());
                //string tmp = input.Substring(2);
                //string[] arr = tmp.Split(' ');

                //if (arr.Length <= n)
                //{
                //    n = arr.Length;
                //}

                //for (int j = n - 1; j >= 0; j--)
                //{
                //    Console.Write(arr[j] + " ");
                //}
                //Console.WriteLine();
            }
        }
    }
}
