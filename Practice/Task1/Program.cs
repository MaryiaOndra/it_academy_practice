using System;
using System.Linq;
using Newtonsoft.Json;

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

                for (int j = 0; j < rectangles.Length; j++)
                {
                    if (rectangles[i].Equals(rectangles.First()))
                    {
                        countDuplicates++;
                    }
                    else
                        bre;
                }
            }

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(rectangles));
            Console.WriteLine($"Duplicates:{countDuplicates}");
        }
    }
}
