using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Identifier
{
    class UniqueItem
    {
        static private int itemID;
        static private int count;

        public UniqueItem()
        {
            count++;
            itemID = count;
        }
        public UniqueItem(int startID)
        {
            count = startID;
            itemID = count;            
        }
    }
}
