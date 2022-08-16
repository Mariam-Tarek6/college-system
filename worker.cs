using Lucene.Net.Support;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace project
{
    class worker:Person
    {
        private long salary;
        public long Salary { get; set; }
        public worker() : base() { }
          public override string ToString()
        {
            return $"{base.ToString()}Salary : {Salary}]" ;
        }
        class Help : IComparer<KeyValuePair<long, int>>
        {
            public int Compare(worker s, worker s1)
            {
                if (s.Salary>s1.Salary)
                {
                    return 1;
                }
                else if (s.Salary < s1.Salary)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

            public int Compare([AllowNull] KeyValuePair<long, int> x, [AllowNull] KeyValuePair<long, int> y)
            {
                throw new NotImplementedException();
            }
        }
    }
}
