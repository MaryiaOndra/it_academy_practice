using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    static class stringExt
    {
        public static string CutString(this String s, char ch) 
        {
            string newString = s.Remove(4, (s.Length - 5));                      

            return newString;
        }
    }
}
