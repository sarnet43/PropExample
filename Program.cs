using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(100, 200);
            Console.WriteLine(box1.Area());
        }
    }
}
