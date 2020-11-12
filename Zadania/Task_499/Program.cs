using System;

namespace Task_499
{
    class Program
    {
        static void Main(string[] args)
        {
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

                switch (cyfraJednosciPodstawy)
                {
                    case 0:
                        Console.WriteLine("0");
                        break;
                    case 1:
                        Console.WriteLine("1");
                        break;
                    case 2:
                        if (wykladniki[i] % 4 == 0)
                        {
                            Console.WriteLine("6");
                        }
                        else if (wykladniki[i] % 4 == 1)
                        {
                            Console.WriteLine("2");
                        }
                        else if (wykladniki[i] % 4 == 2)
                        {
                            Console.WriteLine("4");
                        }
                        else if (wykladniki[i] % 4 == 3)
                        {
                            Console.WriteLine("8");
                        }
                        break;
                    case 3:
                        if (wykladniki[i] % 4 == 0)
                        {
                            Console.WriteLine("1");
                        }
                        else if (wykladniki[i] % 4 == 1)
                        {
                            Console.WriteLine("3");
                        }
                        else if (wykladniki[i] % 4 == 2)
                        {
                            Console.WriteLine("9");
                        }
                        else if (wykladniki[i] % 4 == 3)
                        {
                            Console.WriteLine("7");
                        }
                        break;
                    case 4:
                        if (wykladniki[i] % 2 == 0)
                        {
                            Console.WriteLine("6");
                        }
                        else if (wykladniki[i] % 2 == 1)
                        {
                            Console.WriteLine("4");
                        }
                        break;
                    case 5:
                        Console.WriteLine("5");
                        break;
                    case 6:
                        Console.WriteLine("6");
                        break;
                    case 7:
                        if (wykladniki[i] % 4 == 0)
                        {
                            Console.WriteLine("1");
                        }
                        else if (wykladniki[i] % 4 == 1)
                        {
                            Console.WriteLine("7");
                        }
                        else if (wykladniki[i] % 4 == 2)
                        {
                            Console.WriteLine("9");
                        }
                        else if (wykladniki[i] % 4 == 3)
                        {
                            Console.WriteLine("3");
                        }
                        break;
                    case 8:
                        if (wykladniki[i] % 4 == 0)
                        {
                            Console.WriteLine("6");
                        }
                        else if (wykladniki[i] % 4 == 1)
                        {
                            Console.WriteLine("8");
                        }
                        else if (wykladniki[i] % 4 == 2)
                        {
                            Console.WriteLine("4");
                        }
                        else if (wykladniki[i] % 4 == 3)
                        {
                            Console.WriteLine("2");
                        }
                        break;
                    case 9:
                        if (wykladniki[i] % 2 == 0)
                        {
                            Console.WriteLine("1");
                        }
                        else if (wykladniki[i] % 2 == 1)
                        {
                            Console.WriteLine("9");
                        }
                        break;
                }
            }
        }
    }
}
