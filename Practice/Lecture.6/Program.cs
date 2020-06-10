using System;

namespace Lecture._6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            Task2();
            //Task3();
            //Task4();

            //void Task1()
            //{
            //    object[] empty = new object[default];
            //}

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

            //static void Task3()
            //{
            //    int rend = 0;
            //    int[] randomArray = new[] { };
            //    for (int i = 0; i < length; i++)
            //    {

            //    }
            //}

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
