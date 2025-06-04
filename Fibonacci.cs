using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Fibonacci
    { //1 1 2 3 5 8 13 ...
        public long Get(int i)
        {
            if(i < 0) { return 0; }
            if(i == 1) { return 1; }
            return Get(i - 2) + Get(i - 1);
        }
    }
}
