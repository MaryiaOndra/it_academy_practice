using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    class Rectangle:Shape
    {
        private int Side { get; set; }

        public Rectangle()
        {
            Side = new Random().Next(1, 10);
        }

        public override int FindSquare()
        {
            return Side * Side;
        }
    }
}
