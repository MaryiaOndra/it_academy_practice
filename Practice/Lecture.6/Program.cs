using System;
using System.Linq;

namespace Lecture._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            //Task4();

            void Task1()
            {
                int[] empty = new int[default];
                for (int i = 0; i < empty.Length; i++)
                {
                    Console.WriteLine(empty[i]);
                }
            }

            void Task2()
            {
                object[] newArray = { 32, 'A', "Hello" };

                for (int i = 0; i < newArray.Length; i++)
                {
                    Console.WriteLine(newArray[i]);
                }

                for (int i = 0; i < newArray.Length; i++ )
                {
                    string guys = " ,guys";
                    newArray[0] = Convert.ToInt32(newArray[0]) + 10;
                    newArray[2] = Convert.ToString(newArray[2]) + guys;
                    Console.WriteLine(newArray[i]);
                }

                Console.ReadLine();
            }

            void Task3()
            {
                Random random = new Random();

                int[] randomArray = new int [13];

                for (int i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = random.Next(int.MinValue, int.MaxValue);
                    Console.WriteLine(randomArray[i]);
                }
                        
                Console.WriteLine("It is the max number:" + randomArray.Max());                
            }

            //static void Task4()
            //{
            //    short t = 5;
            //    object o = t;
            //    short sbyte c = (short)o;
            //    Console.WriteLine(c);
            //}
        }
    }
}
