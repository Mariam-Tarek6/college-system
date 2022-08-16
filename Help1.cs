using System.Collections.Generic;

namespace project
{
    class MyCompareClass : IComparer<KeyValuePair<long, int>>
    {
        public int Compare(KeyValuePair<long, int> x, KeyValuePair<long, int> y)
        {
            if (x.Value > y.Value)
            {
                return -1;
            }
            else if (x.Value < y.Value)
                return 1;
            else
            {
                return 0;
            }
        }
    }
}

