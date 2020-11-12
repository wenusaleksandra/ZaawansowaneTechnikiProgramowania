using System;
using System.Collections.Generic;
using System.Linq;

namespace Task_506
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = $@"4
OPSS
ABCDEF
ABBCCCDDDDEEEEEFGGHIIJKKKL
AAAAAAAAAABBBBBBBBBBBBBBBB";
            string count = input.Split("\n")[0];
            int count_num = Convert.ToInt32(count);

            List<string> data = input.Split("\n").ToList();
            data.RemoveAt(0);

            foreach(string line in data)
            {
                int length = line.Length;
                string output = "";
                char currentCharacter = '0';
                int currentCharacterCounut = 0;
                for (int i = 0; i<length; i++)
                {
                    char character = line[i];
                    if(currentCharacter != character || i + 1 == length)
                    {
                        if (currentCharacter == character && i + 1 == length) currentCharacterCounut++;
                        if (currentCharacter != '0')
                        {
                            output += currentCharacter.ToString() + (currentCharacterCounut == 1 ? "" : (currentCharacterCounut == 2 ? currentCharacter.ToString() : (currentCharacterCounut.ToString().Length < currentCharacterCounut ? currentCharacterCounut.ToString() : currentCharacter.ToString())));
                        }
                        currentCharacter = character;
                        currentCharacterCounut = 1;
                    }
                    else
                    {
                        currentCharacterCounut += 1;
                    }
                }
                Console.WriteLine(output);
            }
        }
    }
}
