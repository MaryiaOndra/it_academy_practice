using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Identifier
{
    class UniqueItem
    {
        static private int _startID;
        static private int itemID;
        static private int count;

        public UniqueItem()
        {
            count++;
            _startID = count;
        }
        public UniqueItem(int startID)
        {
            _startID = startID;
            count++;             
        }
    }
}
