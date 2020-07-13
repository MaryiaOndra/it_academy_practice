using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Neighbor
    {
        public string FullName { get; private set; }
        public int FlatNumber { get; private set; }
        public int PhoneNumber { get; private set; }

        public Neighbor(string name, int flatNum, int phoneNum)
        {
            FullName = name;
            FlatNumber = flatNum;
            PhoneNumber = phoneNum;
        }
    }    
}
