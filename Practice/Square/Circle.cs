using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    class Circle:Shape
    {
        private int Radius { get; set; }

        public Circle()
        {
            Radius = new Random().Next(1, 10);
        }

        public override int FindSquare()
        {
            return (int)(Math.PI * Radius * Radius);
        }
    }
}
