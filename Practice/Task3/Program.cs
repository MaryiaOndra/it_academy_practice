using System;
using System.Collections.Generic;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> floorNeighbors = new List<Neighbor>();
            floorNeighbors.Add(new Neighbor("Boris", 12, 124587));
            floorNeighbors.Add(new Neighbor("Masha", 15, 545646));
            floorNeighbors.Add(new Neighbor("Slava", 45, 457898));

            SearchDupl(floorNeighbors, AskNum());

            static int AskNum()
            {
                Console.WriteLine("What is number of your flat?");

                int num = Convert.ToInt32(Console.ReadLine());

                return num ;
            }

            void SearchDupl(List <Neighbor> listN, int number) 
            {
                for (int i = 0; i < listN.Count; i++)
                {
                    if (number.Equals(listN.)) 
                    {
                    
                    }
                }
            }
        }   
    }
}
