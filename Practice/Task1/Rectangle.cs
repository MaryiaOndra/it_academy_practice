using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    struct Rectangle
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
