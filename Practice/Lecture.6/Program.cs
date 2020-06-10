using System;

namespace Lecture._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();

            void Task1()
            {
                object[] empty = new object[default];
            }

           void Task2()
            {
                object[] newArray = { 32, 'A', "Hello" };
                Console.WriteLine(newArray);
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[0] = i + 10;
                    newArray[3] = i + " , guys";
                }             


            }

            static void Task3()
            {
                int rend = 0;
                int[] randomArray = new[] { };
                for (int i = 0; i < length; i++)
                {

                }       
            }
            
            static void Task4()
            {
                short t = 5;
                object o = t;
                sbyte c = (sbyte)o;
                Console.WriteLine(c);
            }            
        }
    }
}
