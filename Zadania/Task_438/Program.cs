
namespace Task_438

{
    internal class Program


    {
        private static void Main(string[] args)

        {
            bool x = true;

            while (x)

            {
                Console.WriteLine("Podaj liczbę od 1 do 100000.");

                string n = Console.ReadLine();

                x = int.TryParse(n, out var result);

                if (!x || result < 1 || result > 100000)

                {
                    Console.WriteLine("Podano błędną wartość");

                    break;
                }

                CheckNumber(result);
            }
        }


        private static void CheckNumber(int number)

        {
            for (int i = 2; i < number; i++)

                if (number % i == 0)

                {
                    Console.WriteLine("NIE");

                    return;
                }

            Console.WriteLine("TAK");
        }
    }
}