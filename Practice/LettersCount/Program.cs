using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the word:");

            string inputWord = Console.ReadLine();

            int count = 0;

            foreach (char i in inputWord)
            {
                if (i == 'a' || i== 'A')
                {
                    count++;
                }
            }

            Console.WriteLine("Your result: " + count);

            Console.ReadLine();
                    

        }
    }
}
