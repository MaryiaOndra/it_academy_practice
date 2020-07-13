using System;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] rectangles = new object[100];

            int countDuplicates = 0;

            for (int i = 0; i < rectangles.Length; i++)
            {
                rectangles[i] = new Rectangle(new Random().Next(1, 10), new Random().Next(1, 10));
                                                
                if (rectangles[i].Equals(rectangles[0]))
                {
                    countDuplicates++;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine($"Duplicates:{countDuplicates}");
        }
    }
}
