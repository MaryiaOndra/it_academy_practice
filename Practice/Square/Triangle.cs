using System;
using System.Collections.Generic;
using System.Text;

namespace Square
{
    class Triangle:Shape
    {
        private int Basis { get; set; }
        private int Height { get; set; }

        public Triangle()
        {
            Basis = new Random().Next(1, 10);
            Height = new Random().Next(1, 10);
        }

        public override int FindSquare()
        {
            return Basis * Height / 2;
        }
    }
}
