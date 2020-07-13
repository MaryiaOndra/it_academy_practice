using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    static class stringExt
    {
        public static string CutString(this String s) 
        {
            string newString = s.Remove(4, (s.Length - 5));
            newString = newString.Insert(5, "...");

            return newString;
        }
    }
}
