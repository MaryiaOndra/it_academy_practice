using System;

namespace Square
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Rectangle(), new Circle(), new Circle(), new Triangle(), new Triangle() };

            foreach (Shape s in shapes)
            {
                Console.WriteLine($"This is [{s.GetType().Name}]. CRL type is [{s.GetType()}]. Square is [{s.FindSquare()}] ");
            }
        }
    }
}
